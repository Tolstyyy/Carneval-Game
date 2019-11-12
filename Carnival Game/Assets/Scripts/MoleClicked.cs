using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleClicked : MonoBehaviour
{
    public GameObject GameManager;

    void Update()
    {
        Input();
    }

    void Input()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0)) // If left mouse button pressed execute the body
        {
            Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition); // Send a ray from the camera to the position of the mouse

            RaycastHit hitInfo; 
            if (Physics.Raycast(ray, out hitInfo))
            {
                ITakeDamage damagable = hitInfo.collider.GetComponent<ITakeDamage>();
                if (damagable != null)
                {
                    damagable.TakeDamage(1.0f);
                }
                else
                {
                    Debug.Log("Didn't hit target");
                    GameManager.GetComponent<Timer>().timer -= 5;
                }
            }
            
        }
    }
}
