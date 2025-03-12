using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        UpdateScore();
    }

    public void IncreaseScore()
    {
        score++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}