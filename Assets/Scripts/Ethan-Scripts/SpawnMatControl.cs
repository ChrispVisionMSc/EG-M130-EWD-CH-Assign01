using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMatControl : MonoBehaviour
{
    public GameObject mat;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    public void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    public void SpawnObject()
    {

     Instantiate(mat, transform.position, transform.rotation);   
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }

}
