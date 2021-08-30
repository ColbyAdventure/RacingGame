using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPick : MonoBehaviour {

    public GameObject CarModel;


    void PickColorRed()
    {
        CarModel.GetComponent<Renderer>().material.color = Color.red;


    }

    void PickColorBlue()
    {
        CarModel.GetComponent<Renderer>().material.color = Color.blue;


    }
    void PickColorYellow()
    {
        CarModel.GetComponent<Renderer>().material.color = Color.yellow;


    }


}
