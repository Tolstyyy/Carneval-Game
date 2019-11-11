using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : MonoBehaviour
{
    public GameObject mole;

    // Spawn Interval
    public int intervalMin = 4;
    public int intervalMax = 30;

    void Start()
    {
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));  // Start the Spawn method
    }

    void Spawn()
    {
        // Spawn the mole
        GameObject g = (GameObject)Instantiate(mole, transform.position, Quaternion.identity);

        // Next Spawn       
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));      
    }
}
