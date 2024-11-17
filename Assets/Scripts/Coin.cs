using UnityEngine;

// The Coin class implements IInteract to define the interaction behavior
public class Coin : MonoBehaviour, IInteract
{
    public int value = 1;

    // Implementing the Interact method defined by IInteract interface
    public void Interact()
    {
        ScoreManager.Instance.AddScore(value);
        Destroy(gameObject);  // Destroy coin after collection
    }
}