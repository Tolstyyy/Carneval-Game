using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int molesClicked;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI newHighScore;   

    void Start()
    {
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString(); // Display the 
        molesClicked = 0; // Set the variable to 0 initially so it shows up in the text
    }

    void Update()
    {
        scoreText.text = "Moles: " + molesClicked.ToString();

        if (molesClicked > PlayerPrefs.GetInt("HighScore", 0)) // Display highscore of moles clicked
        {
            
            PlayerPrefs.SetInt("HighScore", molesClicked);
            highScoreText.enabled = true;
            highScoreText.text = "Highscore: " + molesClicked.ToString(); // Set the variable to a string and display in the text box            
        }
        else
        {
            highScoreText.enabled = false;
        }
    }

    public void ResetHighScore() // Deletes highscore
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScoreText.text = "Highscore: 0";
    }
}
