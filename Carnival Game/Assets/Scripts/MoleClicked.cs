using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoleClicked : MonoBehaviour
{
    public float destroyTime = 1.0f;
    private GameObject gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Manager");
        Destroy(this.gameObject, destroyTime);
    }
    void OnMouseDown() 
    {
        Debug.Log("Clicked");
        Destroy(this.gameObject);

        gameManager.GetComponent<Score>().molesClicked++;
    }

    void Update()
    {
        Destroy(this.gameObject, 1.0f);
    }
}
