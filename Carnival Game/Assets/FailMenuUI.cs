using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailMenuUI : MonoBehaviour
{
    public void Restart() // Loads the game scene
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit() // Quits the game
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
