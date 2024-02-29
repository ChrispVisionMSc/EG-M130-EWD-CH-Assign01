using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Entertrigger : MonoBehaviour
    { 
        
        public GameObject redCube;
        public float headHittingCount;
        // Start is called before the first frame update



        public void OnTriggerEnter(Collider MainCamera)
        {
            redCube.SetActive(true);
            headHittingCount++;
            Debug.Log("ouch" + headHittingCount + "\n\n");
        }
        public void OnTriggerExit(Collider MainCamera)
        {
            redCube.SetActive(false);
        }
    }

