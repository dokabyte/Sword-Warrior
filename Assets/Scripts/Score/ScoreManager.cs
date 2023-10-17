using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
  [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 1;

    private void Awake()
    {
        instance = this;
    }

    // Method to increase the score
    public void IncreaseScore()
    {
        score++;
        UpdateScoreText(score);
    }

    // Method to update the score text on the screen
    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}
