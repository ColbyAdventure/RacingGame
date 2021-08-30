using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosDown : MonoBehaviour {

    public GameObject playerPositionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPos")
        {
            playerPositionDisplay.GetComponent<Text>().text = "1st";
        }

    }
}
