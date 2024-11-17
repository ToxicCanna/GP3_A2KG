using UnityEngine;

// Trap implements the IInteract interface to provide the trap's interaction behavior
public class Trap : MonoBehaviour, IInteract
{
    public int damageAmount = 20;

    // Implement the Interact method from IInteract interface
    public void Interact()
    {
        PlayerHealth.Instance.TakeDamage(damageAmount);
    }
}