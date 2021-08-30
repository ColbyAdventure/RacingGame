using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;








public class ModePick : MonoBehaviour {
    public GameObject ModeUI;


    public void RaceButton() {
        ModeUI.GetComponent<Text>().text = ("Race");
    }

    public void ScoreButton()
    {
        ModeUI.GetComponent<Text>().text = ("Score");
    }

    public void TrailButton()
    {
        ModeUI.GetComponent<Text>().text = ("Trails");
    }

}
