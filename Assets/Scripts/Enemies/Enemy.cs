using UnityEngine;

public class Enemy : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    // Implement this method to handle the enemy's death logic
    public void Die()
    {
        // Handle enemy death logic here

        // Increase the score when the enemy dies
        scoreManager.IncreaseScore();
    }
}
