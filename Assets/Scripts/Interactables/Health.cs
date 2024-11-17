using UnityEngine;

// The Health class implements IInteract to define its interaction behavior
public class Health : MonoBehaviour, IInteract
{
    public int healthAmount = 10;

    // Implementing the Interact method defined by IInteract interface
    public void Interact()
    {
        PlayerHealth.Instance.AddHealth(healthAmount);
        Destroy(gameObject);  // Destroy health pickup after use
    }
}