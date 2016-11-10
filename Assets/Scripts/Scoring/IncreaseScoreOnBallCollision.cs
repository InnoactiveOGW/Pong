using UnityEngine;
using System.Collections;

public class IncreaseScoreOnBallCollision : MonoBehaviour
{
    private ScoreDisplay scoreDisplay;

    // Awake is called before Start.
    private void Awake()
    {
        scoreDisplay = FindObjectOfType<ScoreDisplay>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>() != null)
        {
            scoreDisplay.IncreaseScore();
        }
    }
}
