using System.Collections;								
using System.Collections.Generic;
using UnityEngine;

public class Marker02 : MonoBehaviour
{

    public GameObject Mark02Trig;
    public GameObject Mark03Trig;

    void OnTriggerEnter()
    {
        Mark03Trig.SetActive(true);               
        Debug.Log("Step02");
        Mark02Trig.SetActive(false);              
    }
}
