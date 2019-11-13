using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleClicked : MonoBehaviour
{
    public GameObject GameManager;
    public float removeTimeOnMiss = 10;

    void Update()
    {
        if (Time.deltaTime != 0) // Dont run the input method if the time is stopped
        {
            Input();
        }  
    }

    void Input()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0)) // If left mouse button pressed execute the body
        {
            Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition); // Send a ray from the camera to the position of the mouse

            RaycastHit hitInfo; 
            if (Physics.Raycast(ray, out hitInfo)) // Casts a ray from point a to point b, returns true if hit a collider
            {
                ITakeDamage damagable = hitInfo.collider.GetComponent<ITakeDamage>(); // Damageable is anything with the ITakeDamage interface
                if (damagable != null) // If the thing hit with raycast is damagable then give the TakeDamage method 1f damage every click
                {                   
                    damagable.TakeDamage(1.0f);  
                }
                else
                {
                    Debug.Log("Didn't hit target");
                    GameManager.GetComponent<Timer>().fTimer -= removeTimeOnMiss; // Remove 10 seconds from the variable in the Timer script if hit the ground
                }
            }       
        }
    }
}
