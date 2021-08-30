using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownUI : MonoBehaviour {

    public GameObject CountDownRed;
    public GameObject CountDownYellow;
    public GameObject CountDownGreen;
    public GameObject CountDownGreen2;
    public GameObject CountDownUI;
    //public AudioSource GetReady;																												
	//public AudioSource GoAudio;																												
	public GameObject LapTimer;																												
	public GameObject CarControls;																											
	public AudioSource LevelMusic;																											

	void Start(){
		//Debug.Log ("The Proves The countdown.cs Script Is Run");					
		StartCoroutine (CountStart ());												
	}

	IEnumerator CountStart(){

		//Debug.Log ("The Proves IEnumerator countStart works in The countdown");										//Debugging Tool to make sure the script is running
		yield return new WaitForSeconds (1.0f);										
		//CountDown.GetComponent<Text> ().text = "3";									
		//GetReady.Play ();
        CountDownYellow.SetActive (true);													

		yield return new WaitForSeconds (1);
        CountDownRed.SetActive (false);												
		//CountDown.GetComponent<Text> ().text = "2";									
		//GetReady.Play ();
        CountDownGreen.SetActive (true);													

		yield return new WaitForSeconds (1);
        CountDownYellow.SetActive (false);
        //CountDown.GetComponent<Text> ().text = "1";									
        //GetReady.Play ();															
        CountDownGreen2.SetActive (true);													

		yield return new WaitForSeconds (1);
        CountDownUI.SetActive (false);												
		//GoAudio.Play ();															
		LapTimer.SetActive (true);													
		CarControls.SetActive (true);																					

	}
}
