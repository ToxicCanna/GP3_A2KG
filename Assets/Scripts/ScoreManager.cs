using UnityEngine;

// Single Responsibility: Manages player score.
public class ScoreManager : MonoBehaviour, IScoreSystem
{
    private static ScoreManager _instance;
    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameObject("ScoreManager").AddComponent<ScoreManager>();
            return _instance;
        }
    }

    private int score;

    // Add score
    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Coin Collected! Current Score: " + GetScore());
    }

    // Get current score
    public int GetScore()
    {
        return score;
    }
}
