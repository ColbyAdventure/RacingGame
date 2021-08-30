using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButtons : MonoBehaviour
{

    //public GameObject objectToAdd;
    public static bool disabled = false;




    //public GameObject SoundToggle;
    public static bool SoundEnabled = true;
    public GameObject SoundText;

    //public GameObject MusicToggle;
    public static bool MusicEnabled = true;
    public GameObject MusicText;

    //public GameObject CheatToggle;
    public static bool CheatEnabled = false;
    public GameObject CheatText;




    public void SettingsPick()
    {
 
        if (disabled)
        {
            SoundText.GetComponent<Text>().text = "Off";
            //objectToAdd.SetActive(false);
            disabled = true;
        }
        else
        {
            SoundText.GetComponent<Text>().text = "On";
            //objectToAdd.SetActive(true);
            disabled = false;
        }
    }

    public void SoundSwitch()
    {
        if (SoundEnabled)
        {
            SoundText.GetComponent<Text>().text = "Off";
            PlayerPrefs.SetInt("isSoundOn", 0);
            Debug.Log("Sound Toggle" + PlayerPrefs.GetInt("isSoundOn"));
            SoundEnabled = false;
        }
        else
        {
            SoundText.GetComponent<Text>().text = "On";
            //objectToAdd.SetActive(true);
            PlayerPrefs.SetInt("isSoundOn", 1);
            Debug.Log(PlayerPrefs.GetInt("isSoundOn"));
            //objectToAdd.SetActive(false);
            SoundEnabled = true;
        }
    }


    public void MusicSwitch()
    {
        if (MusicEnabled)
        {
            MusicText.GetComponent<Text>().text = "Off";
            //objectToAdd.SetActive(false);
            PlayerPrefs.SetInt("isMusicOn", 0);
            AudioListener.pause = true;
            Debug.Log("Music Toggle" +PlayerPrefs.GetInt("isMusicOn"));
            MusicEnabled = false;
        }
        else
        {
            MusicText.GetComponent<Text>().text = "On";
            //objectToAdd.SetActive(true);
            PlayerPrefs.SetInt("isMusicOn", 1);
            AudioListener.pause = false;
            Debug.Log("Music Toggle"+PlayerPrefs.GetInt("isMusicOn"));
            MusicEnabled = true;

        }
    }
    public void CheatSwitch()
    {
        if (CheatEnabled)
        {
            CheatText.GetComponent<Text>().text = "Off";
            //objectToAdd.SetActive(false);
            PlayerPrefs.SetInt("isCheatOn", 0);
            Debug.Log("Cheat Toggle"+PlayerPrefs.GetInt("isCheatOn"));
            CheatEnabled = false;
        }
        else
        {
            CheatText.GetComponent<Text>().text = "On";
            //objectToAdd.SetActive(true);
            PlayerPrefs.SetInt("isCheatOn", 1);
            Debug.Log("Cheat Toggle"+PlayerPrefs.GetInt("isCheatOn"));
            CheatEnabled = true;

        }
    }


}
