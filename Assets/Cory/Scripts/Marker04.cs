using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marker04 : MonoBehaviour
{
    public GameObject LapCounter;                                                                                                           //The Display of the LapCounter
    public int LapsDone;

    public GameObject CurrentLapTime;
    public GameObject PostedLapTime;


    public GameObject Mark01Trig;
    public GameObject Mark04Trig;
    public GameObject MarkLastTrig;

    void OnTriggerEnter()
    {
        LapsDone++;                                                                                                                                 //Adds One to the LapsDone Variable
        Debug.Log("Lap complete");
        LapCounter.GetComponent<Text>().text = "0" + LapsDone;
        PostedLapTime.GetComponent<Text>().text = CurrentLapTime.GetComponent<Text>().text;
        CurrentLapTime.GetComponent<Text>().text = 0 + "";

        if (LapsDone >= 3)
        {
            MarkLastTrig.SetActive(true);
            Debug.Log("Laps complete, go get em!");
            Mark04Trig.SetActive(false);

        }
        else
        {
            Mark01Trig.SetActive(true);
            //Debug.Log("Step03");
            Mark04Trig.SetActive(false);
        }
    }
}








