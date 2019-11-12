using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : MonoBehaviour
{
    public GameObject mole;
    public GameObject buffMole;

    private int moleCount;

    private void Update()
    {
        moleCount = GameObject.FindGameObjectsWithTag("Mole").Length;

        if (moleCount == 0)
        {
            Spawn(1);
        }       
    }

    void Spawn(int amount)
    {
        var position = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        
        for (int i = 0; i < amount; i++)
        {
            if (Random.value > 0.7)
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
