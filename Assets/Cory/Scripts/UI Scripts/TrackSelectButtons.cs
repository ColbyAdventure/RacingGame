using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackSelectButtons : MonoBehaviour {

    public GameObject redCarToggle;
    public static bool Reddisabled = false;
    public GameObject redText;

    public GameObject blueCarToggle;
    public static bool Bluedisabled = false;
    public GameObject blueText;

    public GameObject yellowCarToggle;
    public static bool Yellowdisabled = false;
    public GameObject yellowText;




    public void RedCarPick()
    {

        if (Reddisabled)
        {
            redCarToggle.SetActive(false);
            redText.GetComponent<Text>().text = "Off";
            Reddisabled = true;
        }
        else
        {
            redCarToggle.SetActive(true);
            PlayerPrefs.SetInt("TrackIndex", 1);
            blueCarToggle.SetActive(false);
            yellowCarToggle.SetActive(false);
            redText.GetComponent<Text>().text = "On";
            blueText.GetComponent<Text>().text = "Off";
            yellowText.GetComponent<Text>().text = "Off";
            Reddisabled = false;
        }
    }
    public void BlueCarPick()
    {

        if (Bluedisabled)
        {
            blueCarToggle.SetActive(false);
            blueText.GetComponent<Text>().text = "Off";
            Bluedisabled = true;
        }
        else
        {
            redCarToggle.SetActive(false);
            blueCarToggle.SetActive(true);
            PlayerPrefs.SetInt("TrackIndex", 2);
            yellowCarToggle.SetActive(false);
            redText.GetComponent<Text>().text = "Off";
            blueText.GetComponent<Text>().text = "On";
            yellowText.GetComponent<Text>().text = "Off";
            Bluedisabled = false;
        }
    }

    public void YellowCarPick()
    {

        if (Yellowdisabled)
        {
            yellowCarToggle.SetActive(false);
            yellowText.GetComponent<Text>().text = "Off";
            Yellowdisabled = true;
        }
        else
        {
            redCarToggle.SetActive(false);
            blueCarToggle.SetActive(false);
            yellowCarToggle.SetActive(true);
            PlayerPrefs.SetInt("TrackIndex", 3);
            redText.GetComponent<Text>().text = "Off";
            blueText.GetComponent<Text>().text = "Off";
            yellowText.GetComponent<Text>().text = "On";
            Yellowdisabled = false;
        }
    }
}
