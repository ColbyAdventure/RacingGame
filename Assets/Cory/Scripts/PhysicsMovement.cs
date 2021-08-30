using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour {

    Rigidbody playerRigidBody;

    void Start()
    {
        playerRigidBody = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Move player forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidBody.AddForce(new Vector3(0, 0, .2f), ForceMode.VelocityChange);
        }
        // Move player backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidBody.AddForce(new Vector3(0, 0, -.2f), ForceMode.VelocityChange);
        }
        // Move player right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidBody.AddForce(new Vector3(.2f, 0,0 ), ForceMode.VelocityChange);
        }
        // Move player left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidBody.AddForce(new Vector3(-.2f, 0,0 ), ForceMode.VelocityChange);
        }
    }
}
