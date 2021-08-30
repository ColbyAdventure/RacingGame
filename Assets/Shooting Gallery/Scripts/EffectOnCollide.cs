using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOnCollide : MonoBehaviour
{
    public GameObject Effect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter (){
        Destroy(gameObject);
        Instantiate(Effect, transform.position, Quaternion.identity);
	}
}
