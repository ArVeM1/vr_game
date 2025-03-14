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
            RespawnSphere(collision.gameObject);
            canScore = false; 
            Invoke(nameof(ResetScoreFlag), 0.1f); 
        }
    }

    private void RespawnSphere(GameObject sphere)
    {
        Rigidbody rb = sphere.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero; 
            rb.angularVelocity = Vector3.zero; 
        }

        if (sphere.TryGetComponent<SphereInitialPosition>(out var initialPosition))
        {
            sphere.transform.position = initialPosition.initialPosition;
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
