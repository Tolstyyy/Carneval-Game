using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int timer;                   // Time left until fail   
    public float fTimer = 30f;         // Same
    
    public GameObject failMenuUI;       // Reference to the fail menu ui

    
    void Update()
    {
        fTimer -= Time.deltaTime;
        timer = (int)fTimer;

        if (timer <= 0)
        {
            Debug.Log("Out of time");
            Time.timeScale = 0f;           
        }

        if (Time.timeScale == 0)
        {
            failMenuUI.SetActive(true);
        }
        else
        {
            failMenuUI.SetActive(false);
        }
    }
}
