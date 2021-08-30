using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtomScript : MonoBehaviour {

    public GameObject bill;

	public void EnableCube(GameObject objecttoEnable)
    {
        objecttoEnable.SetActive(!objecttoEnable.activeSelf);
    }
}
