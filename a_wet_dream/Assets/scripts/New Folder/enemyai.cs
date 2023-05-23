using UnityEngine;
using UnityEngine.UI;

public class enemyai : MonoBehaviour
{
    public enemy enemys;

    public float speed = 5f;
    public float attackDelay = 4f;
    public int damage = 10;

    private Transform playerTransform;
    private Vector3 lastKnownPlayerPosition;
    private bool isWaiting;
    private float waitTimer;

    public Slider healthSlider;

    private void Start()
    {
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

                
                if (transform.position == lastKnownPlayerPosition)
                {
                    
                    isWaiting = true;
                    waitTimer = attackDelay;
                }
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
