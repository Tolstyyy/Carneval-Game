using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public int molesClicked;
    public TextMeshProUGUI scoreText;
    public Canvas canvas;

    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        molesClicked = 0;
    }

    void Update()
    {
        scoreText.text = "Moles: " + molesClicked.ToString();
    }
}
