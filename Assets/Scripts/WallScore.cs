using TMPro;
using UnityEngine;

public class WallScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    private int score = 0; 
    private bool canScore = true; 

    private void Start()
    {
        UpdateScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && canScore)
        {
            score++;
            UpdateScore();
            canScore = false; 
            Invoke(nameof(ResetScoreFlag), 0.1f); 
        }
    }

    private void ResetScoreFlag()
    {
        canScore = true;
    }

    private void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
