//Cory Ronald
//Based On
// Floater v0.0.2
// by Donovan Keith
//
// [MIT License](https://opensource.org/licenses/MIT)

using UnityEngine;
using System.Collections;

// Makes objects float up & down while gently spinning.
public class MagicHover30 : MonoBehaviour
{
    // User Inputs
    public float degreesPerSecondX = 15.0f;
    public float degreesPerSecondY = 15.0f;
    public float degreesPerSecondZ = 15.0f;

    //Amplitude of Movement

    public float amplitudeX = 0.5f;
    public float amplitudeY = 2000.5f;
    public float amplitudeZ = 0.5f;

    //How often It Cycles (X Times per Second)

    public float frequencyX = 1f;
    public float frequencyY = 1f;
    public float frequencyZ = 1f;


    // Position Storage Variables
    //Originals
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    //Cory's
    Vector3 posOffsetX = new Vector3();
    Vector3 tempPosX = new Vector3();
    Vector3 posOffsetY = new Vector3();
    Vector3 tempPosY = new Vector3();
    Vector3 posOffsetZ = new Vector3();
    Vector3 tempPosZ = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
        posOffsetX = transform.position;
        posOffsetY = transform.position;
        posOffsetZ = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecondY, 0f), Space.World);

        // Spin object around X-Axis
        transform.Rotate(new Vector3(Time.deltaTime * degreesPerSecondX, 0f, 0f), Space.World);

        // Spin object around X-Axis
        transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * degreesPerSecondZ), Space.World);


        //Float up/ down with a Sin()
        tempPosY = posOffsetY;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequencyY) * amplitudeY;

        //transform.position = tempPosY;

        //// Float Left/Right with a Sin()
        //tempPosX = posOffsetX;
        //tempPos.x += Mathf.Sin(Time.fixedTime * Mathf.PI * frequencyX) * amplitudeX;

        //transform.position = tempPosX;

        //// Float forward/backward with a Sin()
        //tempPosZ = posOffsetZ;
        //tempPos.z += Mathf.Sin(Time.fixedTime * Mathf.PI * frequencyZ) * amplitudeZ;

        //transform.position = tempPosZ;
    }
}
