using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    //Settings Menu Toggles

    public int soundOnorOff =1;
    public int musicOnorOff =1;
    public int cheatOnorOff;

    //Settings for Colour (Car Select, *wink* *wink*)

    public int ColourPickIndex;

    public GameObject RedCar;
    public GameObject BlueCar;
    public GameObject YellowCar;


    public GameObject playersCar;

    //Stuff For Each Track

    public GameObject track01Stuff;
    public GameObject track02Stuff;
    public GameObject track03Stuff;

    //What Mode We in, Dawg!
    public GameObject ScoreUI;
    public GameObject LapUI;
    public GameObject LapTime;
    public GameObject BestTimeUI;

    public GameObject EndingTrigger;

    public GameObject Track01Prizes;
    public GameObject Track02Prizes;
    public GameObject Track03Prizes;

    public GameObject musicMaker;
    //public GameObject soundMaker;
    //public GameObject CheatMaker;

    // Use this for initialization
    void Start () {
        //cuz it just needs to do it the once

        PlayerPrefs.GetInt("isSoundOn");
        PlayerPrefs.GetInt("isMusicOn");
        PlayerPrefs.GetInt("isCheatOn");

        // PlayerPrefs.GetString("CarMainColour");
        Debug.Log("This Is the isSoundOn: " + PlayerPrefs.GetInt("isSoundOn"));
        Debug.Log("This Is the isMusicOn: " + PlayerPrefs.GetInt("isMusicOn"));
        Debug.Log("This Is the isCheatOn: " + PlayerPrefs.GetInt("isCheatOn"));

        PlayerPrefs.GetInt("CarColourIndex");
        PlayerPrefs.GetInt("TrackIndex");
        PlayerPrefs.GetInt("ModeIndex");

        Debug.Log("This Is the Car Colour Index: " +PlayerPrefs.GetInt("CarColourIndex"));
        Debug.Log("This Is the Car Track Index: " + PlayerPrefs.GetInt("TrackIndex"));
        Debug.Log("This Is the Track Mode Index: " + PlayerPrefs.GetInt("ModeIndex"));

        //***************************************************************
        //***************************************************************
        //Settings Toggles



        //***************************************************************
        //***************************************************************
        //Colour Toggles

        if ((PlayerPrefs.GetInt("CarColourIndex")) == 1)
        {
            //playersCar.GetComponent<Renderer>().material.color = Color.red;
            RedCar.SetActive(true);
            BlueCar.SetActive(false);
            YellowCar.SetActive(false);

            // return;
        }

        if ((PlayerPrefs.GetInt("CarColourIndex")) == 2)
        {
            playersCar.GetComponent<Renderer>().material.color = Color.blue;
            RedCar.SetActive(false);
            BlueCar.SetActive(true);
            YellowCar.SetActive(false);
            //return;
        }
        if ((PlayerPrefs.GetInt("CarColourIndex")) == 3)
        {
            playersCar.GetComponent<Renderer>().material.color = Color.yellow;
            RedCar.SetActive(false);
            BlueCar.SetActive(false);
            YellowCar.SetActive(true);
            // return;
        }

        //***************************************************************
        //***************************************************************
        //Track Toggles

        if ((PlayerPrefs.GetInt("TrackIndex")) == 1)
        {
            //Enable Track One Stuff
            track01Stuff.SetActive(true);
            track02Stuff.SetActive(false);
            track03Stuff.SetActive(false);
            Debug.Log("This Is Track: 01!");
            // return;
        }
        if ((PlayerPrefs.GetInt("TrackIndex")) == 2)
        {
            //Enable Track One Stuff
            track01Stuff.SetActive(false);
            track02Stuff.SetActive(true);
            track03Stuff.SetActive(false);
            Debug.Log("This Is Track 02!");
            // return;
        }
        if ((PlayerPrefs.GetInt("TrackIndex")) == 3)
        {
            //Enable Track 3e Stuff
            track01Stuff.SetActive(false);
            track02Stuff.SetActive(false);
            track03Stuff.SetActive(true);
            Debug.Log("This Is Track 03!");
            // return;
        }


        //***************************************************************
        //***************************************************************
        //Mode Toggles



        if ((PlayerPrefs.GetInt("ModeIndex")) == 1)
        {
            //Enable Mode One (Racing!) Stuff
            ScoreUI.SetActive(false);
            LapUI.SetActive(true);
            LapTime.SetActive(true);
            BestTimeUI.SetActive(true);
          //  EndingTrigger.SetActive(true);
            Track01Prizes.SetActive(false);
            Track02Prizes.SetActive(false);
            Track03Prizes.SetActive(false);
            Debug.Log("This Is Race Mode!");
            // return;
        }
        if ((PlayerPrefs.GetInt("ModeIndex")) == 2)
        {
            //Enable Mode One (Score!) Stuff
            ScoreUI.SetActive(true);
            LapUI.SetActive(true);
            LapTime.SetActive(true);
            BestTimeUI.SetActive(false);
           // EndingTrigger.SetActive(false);
            Track01Prizes.SetActive(true);
            Track02Prizes.SetActive(true);
            Track03Prizes.SetActive(true);
            Debug.Log("This Is Score Mode!");
            // return;
        }

        if ((PlayerPrefs.GetInt("ModeIndex")) == 3)
        {
            //Enable Mode One (Trials!) Stuff
            ScoreUI.SetActive(false);
            LapUI.SetActive(false);
            LapTime.SetActive(true);
            BestTimeUI.SetActive(false);
         //   EndingTrigger.SetActive(false);
            Track01Prizes.SetActive(false);
            Track02Prizes.SetActive(false);
            Track03Prizes.SetActive(false);
            Debug.Log("This Is Traiiiiils Mode!");
            // return;
        }
    }




    // Update is called once per frame
    void Update () {
        if ((PlayerPrefs.GetInt("ModeIndex")) == 3) {
            EndingTrigger.SetActive(false);
        }

        if (musicOnorOff == 0)
        {
            AudioListener.pause = true;
            //musicMaker.GetComponent<GameObject>().SetActive(false);
        }

        if (musicOnorOff == 1)
        {
            AudioListener.pause = false;
            // musicMaker.GetComponent<GameObject>().SetActive(true);
        }


    }
}
