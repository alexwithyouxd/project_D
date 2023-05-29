using UnityEngine;
using UnityEngine.UI;

public class enemyai : MonoBehaviour
{
    public enemy enemys;

    public float speed = 5f;
    public float attackDelay = 4f;
    public int damage = 5;

    private Transform playerTransform;
    private Vector3 lastKnownPlayerPosition;
    private bool isWaiting;
    private float waitTimer;

    public float knockbackForce = 5f;

    public Slider healthSlider;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemys = GetComponent<enemy>();
        
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        UpdateHealthUI();
        if (playerTransform != null)
        {
            if (!isWaiting)
            {
                
                lastKnownPlayerPosition = playerTransform.position;

               
                transform.position = Vector2.MoveTowards(transform.position, lastKnownPlayerPosition, speed * Time.deltaTime);

                
                /*if (transform.position == lastKnownPlayerPosition)
                {
                    
                    isWaiting = true;
                    waitTimer = attackDelay;
                }*/

                
            }
            else
            {
                
                waitTimer -= Time.deltaTime;

               
                if (waitTimer <= 0f)
                {
                    
                    Attack();
                    isWaiting = false;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            // Apply knockback to the player
            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            if (playerRigidbody != null)
            {
                Vector2 knockbackDirection = playerTransform.position - transform.position;
                knockbackDirection.Normalize();

                playerRigidbody.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
            }
            /*isWaiting = true;
            waitTimer = attackDelay;*/
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            isWaiting = true;
            waitTimer = attackDelay;
        }
    }*/
    private void Attack()
    {
     
        Debug.Log("Attacking player's last known position: " + lastKnownPlayerPosition);

      
        PlayerHealth playerHealth = playerTransform.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            
            playerHealth.TakeDamage(damage);
        }
    }

    private void UpdateHealthUI()
    {
        
        if (healthSlider != null)
        {
            healthSlider.value = enemys.currenthealth;
        }
    }
}
