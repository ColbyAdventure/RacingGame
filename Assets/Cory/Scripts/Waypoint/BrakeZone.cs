using UnityEngine;
using System.Collections;

public class BrakeZone : MonoBehaviour {

	// Use this for initialization
	public float targetSpeed = 14f;

	float orginalSpeed;

	void OnTriggerEnter(Collider col)
	{

		if (col.CompareTag ("Player")) {//needs to be changed to "other car" or whatever
			orginalSpeed = col.GetComponent<UnityEngine.AI.NavMeshAgent> ().speed;
			col.GetComponent<UnityEngine.AI.NavMeshAgent> ().speed = targetSpeed;
		}
		
	}

	void OnTriggerExit(Collider col)
	{

		if(col.CompareTag("Player"))//needs to be changed to "other car" or whatever
            col.GetComponent<UnityEngine.AI.NavMeshAgent> ().speed = orginalSpeed;
	}
}
