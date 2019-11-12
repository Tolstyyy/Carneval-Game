using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour, ITakeDamage
{
    public float moleHealth = 1.0f;                 // Health of the mole
    public ParticleSystem onDeathParticle;          // Particle system when mole dies
    private GameObject gameManager;                 // Game manager gameobject reference

    public void Start()
    {
        Destroy(gameObject, 2f);
        gameManager = GameObject.FindGameObjectWithTag("Manager"); // Find the game manager 

    }

    public void TakeDamage(float damage)
    {
        moleHealth -= damage;
        if (moleHealth <= 0)
        {
            //onDeathParticle.Play();           
            gameManager.GetComponent<Score>().molesClicked++; // Increment amount of moles clicked variable in the Score script attached to game manager
            gameManager.GetComponent<Timer>().fTimer += 5f;
            Destroy(gameObject);
        }
    }
}
