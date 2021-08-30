using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCarMovement : MonoBehaviour {

    public float rotationSpeed = 100.0f;
    Rigidbody playerRigidBody;

    // Use this for initialization
    void Start () {
        playerRigidBody = transform.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        //rotation *= Time.deltaTime;
        //transform.Rotate(0, rotation, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidBody.AddForce(new Vector3(0, 0, .9f), ForceMode.VelocityChange);
        }
        // Move player backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidBody.AddForce(new Vector3(0, 0, -.2f), ForceMode.VelocityChange);
        }
        // Move player right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        }
        // Move player left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            rotation *= Time.deltaTime;
            transform.Rotate(0, -rotation, 0);
            //playerRigidBody.AddForce(new Vector3(-.2f, 0, 0), ForceMode.VelocityChange);
        }
    }


}
       // Move player forward
       