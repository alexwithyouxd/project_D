using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameoverpanel;
    public GameObject slider;
    public int maxHealth = 100;
    [SerializeField]private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player has died");
        Time.timeScale = 0f;
        gameoverpanel.SetActive(true);
        slider.SetActive(false);





    }
}
