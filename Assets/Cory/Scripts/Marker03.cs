using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker03 : MonoBehaviour
{

    public GameObject Mark03Trig;
    public GameObject Mark04Trig;

    void OnTriggerEnter()
    {
        Mark04Trig.SetActive(true);
        Debug.Log("Step03");
        Mark03Trig.SetActive(false);
    }
}
