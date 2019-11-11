using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleClicked : MonoBehaviour
{
    public float destroyTime = 1.0f;
    private GameObject gameManager;
    public ParticleSystem hitParticle;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Manager");
        
    }
    void OnMouseDown() 
    {
        hitParticle.Play();
        Destroy(gameObject);
        gameManager.GetComponent<Score>().molesClicked++; // Increment amount of moles clicked variable in the Score script attached to game manager
    }

    void Update()
    {
        Destroy(gameObject, destroyTime);
    }


}
