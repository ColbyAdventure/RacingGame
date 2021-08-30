using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicButtonAdd : MonoBehaviour {

    public GameObject objectToAdd;
    public static bool disabled = false;


	// Use this for initialization
	void Start () {
       // RedOptionPick();
	}
	
	// Update is called once per frame
	void Update () {

	}


    public void RedOptionPick()
    {
        disabled = !disabled;
        if (disabled)
            objectToAdd.SetActive(false);
        else
            objectToAdd.SetActive(true);
    }
}
