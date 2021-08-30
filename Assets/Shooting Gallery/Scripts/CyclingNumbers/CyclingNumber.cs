using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CyclingNumber : MonoBehaviour {

    public Text NumberText;
    public float animationTime = 1.0f;

    public float desiredNumber;
    private float initialNumber;
    private float currentNumber;


    public void SetNumber(float value)
    {
        initialNumber = currentNumber;
        desiredNumber = value;
    }

    public void AddToNumber(float value) {
        initialNumber = currentNumber;
        desiredNumber += value;
    }


    public void Update() {
        if (currentNumber != desiredNumber)
        {
            if (initialNumber < desiredNumber)
            {
                currentNumber += (animationTime * Time.deltaTime) * (desiredNumber - initialNumber);
                if (currentNumber >= desiredNumber)
                {
                    currentNumber = desiredNumber;
                }
            }
            else
            {
                if (initialNumber > desiredNumber)
                {
                    currentNumber -= (animationTime * Time.deltaTime) * (initialNumber- desiredNumber);
                    if (currentNumber <= desiredNumber)
                    {
                        currentNumber = desiredNumber;
                    }
                }
            }
            NumberText.text = currentNumber.ToString("0.0");
        }
    }
}
