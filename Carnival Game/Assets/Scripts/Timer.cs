using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int timer = 30;              // Time left in the game
    public float fTimer = 30f;          // Time but in float
    public GameObject failMenuUI;       // Reference to the fail menu ui

    
    void Update() // Updates the body every frame
    {
        fTimer -= Time.deltaTime; // Basically a timer. The value set in the fTimer is minus time each frame
        timer = (int)fTimer; // Convert the floatTimer to an int so it doesnt show the extra decimals when converted to string in score script

        if (timer <= 0) // If the timer has reached 0 or is below it stop the time
        {
            Debug.Log("Out of time");
            Time.timeScale = 0f;           
        }
        else // If not set the time speed back to normal
        {
            Time.timeScale = 1f;
        }

        if (Time.timeScale == 0) // If time has stopped
        {
            failMenuUI.SetActive(true); // Show the failmenu
        }
        else
        {
            failMenuUI.SetActive(false); // Otherwise hide it
        }
    }
}
