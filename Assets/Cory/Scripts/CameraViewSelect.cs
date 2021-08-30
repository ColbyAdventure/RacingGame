using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewSelect : MonoBehaviour {

    public GameObject normalCam;
    public GameObject farCam;
    public GameObject FPCam;
    public GameObject toyCam;
    public GameObject tireCam;

    public int CamMode;

    // Update is called once per frame
        void Update()
        {
        if (Input.GetKeyDown(KeyCode.Space))
            {                                                                                      
                if (CamMode == 4)
                {                                                                                  
                    CamMode = 0;                                                                   
                }
                else
                {
                    CamMode += 1;                                                                  
                }
                StartCoroutine(ModeChange());                                                      
            }
        }

        IEnumerator ModeChange()
        {                                                                                          
            yield return new WaitForSeconds(0.01f);
            if (CamMode == 0)
            {                                                                                      
                normalCam.SetActive(true);
                tireCam.SetActive(false);
            }
            if (CamMode == 1)
            {                                                                                      
                farCam.SetActive(true);
                normalCam.SetActive(false);
            }
            if (CamMode == 2)
            {                                                                                      
                FPCam.SetActive(true);
                farCam.SetActive(false);
            }
            if (CamMode == 3)
            {                                                                                      
                toyCam.SetActive(true);
                FPCam.SetActive(false);
            }

            if (CamMode == 4)
            {
                tireCam.SetActive(true);
                toyCam.SetActive(false);
            }


    }

}

