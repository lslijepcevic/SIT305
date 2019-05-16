using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
         /*
        Score manager syatem works for keep tracke the current score and high score when the user start to play the game
        and show as a text on the screen.
        We use UI text, counter, point per second which is changable into the unity environment and score increasing.
        */

    // Refrences for our text object.
    public Text scoreText;
    public Text highScoreText;

    // values for score and high score.
    public float scoreCount;
    public float highScoreCount;

    // Value for how much score our character can get per second.
    public float pointPerSecond;

    // This boolean is for when the game is stop, increasing the score stop as well.
    public bool scoreIncreasing;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetFloat("HighScore") != null)
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        /* This method works for adding score for the player. 
        (Time.deltatime is the time is taken from the last update loop to the current one).
        */

        if (scoreIncreasing)
        {
            scoreCount += pointPerSecond * Time.deltaTime;
            PlayerPrefs.SetFloat("Score", scoreCount);
        }
        // This if condition is for storing high score if our current score is more than previous high score.

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }


        /* add score functoin to add score into the text in our screen. when the score is increasing, it shows
        on text object on the screen. and this method works for the high score as well.
        Mathf.Round make whole number for our score instead of float number.
        */

        scoreText.text = "Your Score: " + Mathf.Round (scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round (highScoreCount); 
    }
}
