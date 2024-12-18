using UnityEngine;

public class HealthPotionScript : MonoBehaviour
{

    public PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTag"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            playerHealth.AddHealth(15);
            Destroy(gameObject);
        }
    }
}
