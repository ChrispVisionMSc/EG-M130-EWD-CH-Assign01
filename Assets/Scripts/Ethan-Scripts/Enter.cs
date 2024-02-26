using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject Head;
    
    private void OnTriggerEnter()
    {
        Head.SetActive(true);
    }
    private void OnTriggerExit()
    {
        Head.SetActive(false);
    }
}
