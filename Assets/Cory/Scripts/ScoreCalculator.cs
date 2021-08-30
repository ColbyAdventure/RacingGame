using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour {
    public float ScoreTimer;
    public float Score;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ScoreTimer = ScoreTimer + Time.deltaTime;
        Score = 500 - (3 * ScoreTimer);

    }
}
