using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GasGauge : MonoBehaviour
{

    public static int health = 100;
    public static int Mana = 0;
    public GameObject playerModel;
    public Slider healthBar;
    public Slider manaBar;
    public Rigidbody rb;
    public GameObject GameOverUI;
    public GameObject VictoryUI;

    // Use this for initialization
    void Start()
    {
        health = 500;
        InvokeRepeating("ReduceHealth", 1, 1);
        InvokeRepeating("IncreaseMana", 1, 1);
    }

    void ReduceHealth()
    {
        health = health -1;
        healthBar.value = health;

        if (health <= 0)
        {
            Debug.Log("The Health Has Reached Zero!");
            //Set the player's speed to 0
            Time.timeScale = 0.00f;
            VictoryUI.SetActive(false);
            GameOverUI.SetActive(true);

        }
    }

    //void IncreaseMana()
    //{

    //    manaBar.value = rb.velocity.z;



    //    if (Mana >= 100)
    //    {
    //        Debug.Log("The Mana Has Reached Full!");

    //    }
    //}
}
