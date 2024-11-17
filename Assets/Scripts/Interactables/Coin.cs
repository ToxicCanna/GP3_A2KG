using UnityEngine;

// The Coin class implements IInteract to define the interaction behavior
public class Coin : MonoBehaviour, IInteract
{
    public int value = 1;
    private IScoreSystem scoreSystem;

    // Constructor injection (for cases when Coin is instantiated in code)
    public void SetScoreSystem(IScoreSystem system)
    {
        scoreSystem = system;
    }

    private void Awake()
    {
        if (scoreSystem == null)
        {
            scoreSystem = ScoreManager.Instance;  // Fallback to the default ScoreManager
        }
    }

    // Implementing the Interact method defined by IInteract interface
    public void Interact()
    {
        scoreSystem.AddScore(value);  // Add score using the abstraction
        Destroy(gameObject);  // Destroy coin after collection
    }
}