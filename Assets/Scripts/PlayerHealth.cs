using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance { get; private set; }
    public int currentHealth = 100;
    public int maxHealth = 100;

    void Awake()
    {
        // Singleton setup
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Display initial health when the game starts
        Debug.Log("Game Started! Player Health: " + currentHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        // Decrease health and ensure it doesn't go below zero
        currentHealth -= damageAmount;
        currentHealth = Mathf.Max(currentHealth, 0);

        // Log health change in the console
        Debug.Log("Player took " + damageAmount + " damage. Current Health: " + currentHealth);
    }

    public void AddHealth(int amount)
    {
        // Add health and ensure it doesn't exceed max health
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);

        // Log the health addition
        Debug.Log("Player added " + amount + " health. Current Health: " + currentHealth);
    }

    // Getter for currentHealth
    public int GetHealth()
    {
        return currentHealth;
    }
}