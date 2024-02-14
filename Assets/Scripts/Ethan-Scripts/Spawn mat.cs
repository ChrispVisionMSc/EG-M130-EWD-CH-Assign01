using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmat : MonoBehaviour
{
    public float lifeTime;

    private void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);

        }

    }
}
