using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerLast : MonoBehaviour
{
    public GameObject GameOverUI;




    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0.0f;
            GameOverUI.SetActive(true);
        }



    }


}


