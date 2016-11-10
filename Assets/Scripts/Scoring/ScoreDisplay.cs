using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplay : MonoBehaviour
{
    private Text text;
    private int score;

    public void IncreaseScore()
    {
        score++;
        text.text = "Score: " + score;
    }

	private void Start ()
    {
        text = GetComponent<Text>();
	}
}
