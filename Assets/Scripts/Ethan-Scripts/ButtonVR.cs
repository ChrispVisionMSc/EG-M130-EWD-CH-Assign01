using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject Button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            Button.transform.localPosition = new Vector3(0f, 0.003f, 0f);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser) {
            Button.transform.localPosition = new Vector3(0f, 0.015f, 0);
            onRelease.Invoke();
            isPressed=false;
        
        }
    }
    //public void *insert name here for what the btton does*(){}

}
