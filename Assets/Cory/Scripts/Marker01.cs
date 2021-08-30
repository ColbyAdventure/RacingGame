using System.Collections;								
using System.Collections.Generic;
using UnityEngine;

public class Marker01 : MonoBehaviour
{

    public GameObject Mark01Trig;
    public GameObject Mark02Trig;

   // public AudioSource hitWaypointSound;

    //void Start() {
    //    hitWaypointSound = GetComponent<AudioSource>();
    //}

    void OnTriggerEnter()
    {
       // hitWaypointSound.Play();
        Mark02Trig.SetActive(true);               
        Debug.Log("Step01");
        Mark01Trig.SetActive(false);              
    }
}
