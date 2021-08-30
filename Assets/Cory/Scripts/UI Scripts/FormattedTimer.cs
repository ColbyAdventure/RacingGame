using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormattedTimer : MonoBehaviour
{

    public float theTimeThatPasses;
    public float TimeFormatted;
    //public float theRawTimeToCompareWithTheBestSlowestTime;
    public GameObject FormattedTimeUI;
    public int Minutes;

    // Use this for initialization
    void Start()
    {
        theTimeThatPasses = 0.0f;
        TimeFormatted = theTimeThatPasses;
        Minutes = 0;
        // InvokeRepeating("UpdateFormattedTimer", 0, 1);
    }


    void Update() {
        theTimeThatPasses = theTimeThatPasses + Time.deltaTime;
        TimeFormatted = TimeFormatted + Time.deltaTime;
        if (TimeFormatted >= 60) {
            Minutes++;
            TimeFormatted = 0;
        }
        FormattedTimeUI.GetComponent<Text>().text = Minutes + ":" + string.Format("{0:00.00}", TimeFormatted);
    }


    //void UpdateFormattedTimer()
    //{
    //    theTimeThatPasses++;
    //    FormattedTimeUI.GetComponent<Text>().text = string.Format("{0:00.00}", theTimeThatPasses);
    //}



}
