using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RawTimer : MonoBehaviour {

    public float theTimeThatPasses;
    public GameObject RawTimeUI;

	// Use this for initialization
	void Start () {
        theTimeThatPasses = -1;
        InvokeRepeating("UpdateRawTimer", 0, 1);
    }



    void UpdateRawTimer() {
        theTimeThatPasses++;
        RawTimeUI.GetComponent<Text>().text = theTimeThatPasses + "";
    }

}
