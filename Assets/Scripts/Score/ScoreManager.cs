using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Method to increase the score
    public void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }

    // Method to update the score text on the screen
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
