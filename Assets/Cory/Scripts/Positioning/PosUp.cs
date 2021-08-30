using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour {

    public GameObject playerPositionDisplay;

    void OnTriggerExit(Collider other) {
        if (other.tag == "CarPos")
        {
            
            playerPositionDisplay.GetComponent<Text>().text = "2nd";
        }

    }
}
