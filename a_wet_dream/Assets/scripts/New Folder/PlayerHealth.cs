using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameoverpanel;
    public GameObject slider;
    public GameObject slider1;
    public Slider slider2;
    public int maxHealth = 100;
    [SerializeField]private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthUI();

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
        slider1.SetActive(false);






    }
    private void UpdateHealthUI()
    {

        if (slider2 != null)
        {
            slider2.value = currentHealth;
        }
    }
}
