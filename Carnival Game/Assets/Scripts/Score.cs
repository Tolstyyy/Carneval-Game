using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int molesClicked;                    // Amount of moles that have been clicked 
    
    public TextMeshProUGUI scoreText;           // Reference to the score text
    public TextMeshProUGUI highScoreText;       // Reference to the highscore text
    public TextMeshProUGUI timerText;           // Reference to the timer text

    public GameObject highScoreObject;          // Reference to the Gameobject containing the highscore text
    public GameObject scoreObject;              // Reference to the Gameobject containing the score text
    public GameObject timerObject;              // Reference to the Gameobject containing the timer text

    void Start()
    {
        molesClicked = 0; // Shows 0 in the string
    }

    void Update()
    {
        TimeLeft();
        MoleScore();
        ShowHighscore();
    }

    private void TimeLeft()
    {
        timerText.text = "Time: " + GetComponent<Timer>().timer.ToString();
    }

    public void MoleScore()
    {
        scoreText.text = "Moles: " + molesClicked.ToString();

        if (Time.deltaTime == 0)
        {
            scoreObject.SetActive(false);
        }        
    }

    public void ShowHighscore() // Show highscore when a new highscore is reached
    {       

        if (molesClicked > PlayerPrefs.GetInt("HighScore", 0)) // Display highscore of moles clicked
        {
            highScoreObject.SetActive(true);

            PlayerPrefs.SetInt("HighScore", molesClicked);
            highScoreText.text = "Highscore: " + molesClicked.ToString(); // Set the variable to a string and display in the text box            
        }
        else if (molesClicked < PlayerPrefs.GetInt("HighScore", 0))
        {
            highScoreObject.SetActive(false);
        }
    }

    public void ResetHighScore() // Deletes highscore (used with a temporary button)
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScoreText.text = "Highscore: 0";
    }
}
