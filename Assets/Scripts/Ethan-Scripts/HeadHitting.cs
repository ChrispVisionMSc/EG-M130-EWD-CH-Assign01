using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadHitting : MonoBehaviour
{
   
    public class Entertrigger : MonoBehaviour
    { 
        public int headHittingCount =0;
        public GameObject redCube;
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider MainCamera)
        {
            redCube.SetActive(true);
            headHittingCount++;
            Debug.Log("ouch");
        }
        public void OnTriggerExit(Collider MainCamera)
        {
            redCube.SetActive(false);
        }
    }
}
