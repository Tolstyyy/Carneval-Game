using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawn : MonoBehaviour
{
    public GameObject mole;                     // Reference to the mole prefab                       
    public GameObject buffMole;                 // Reference to the buffMole variant of mole prefab
    public float buffMoleSpawnChance = 0.1f;    // Chance to spawn a buff mole 
    private int moleCount;                      // Number of moles in the scene

    private void Update()
    {
        moleCount = GameObject.FindGameObjectsWithTag("Mole").Length; // The number of moles is the number of gameobjects found with the "Mole" tag

        if (moleCount == 0) // If there are no moles in the scene spawn 1 mole
        {
            Spawn(1);
        }       
    }

    void Spawn(int amount)
    {
        var position = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        
        for (int i = 0; i < amount; i++)
        {
            if (Random.value < buffMoleSpawnChance)
            {
                Instantiate(buffMole, position, Quaternion.identity);
            }
            else
            {
                Instantiate(mole, position, Quaternion.identity);
            }       
        }
    }
}
