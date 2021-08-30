using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class Collectable : MonoBehaviour {
    //Ginish This

    public Text ScoreText;
    public int ScoreInt;

    public GameObject NextPrize;

    void OnTriggerEnter(Collider other)
    {
        //ScoreText.text = "sfd";
        Debug.Log("Collectible collected");
        Debug.Log("Value Of Before ScoreInt: " + ScoreInt);
        int.TryParse(ScoreText.text, out ScoreInt);
        ScoreInt++;
        Debug.Log("Value Of aAfter ScoreInt: " + ScoreInt);
        ScoreText.text = ScoreInt + "";
        NextPrize.SetActive(true);
        this.gameObject.SetActive(false);
        //Destroy(this.gameObject);






        // FormattedTimeUI.GetComponent<Text>().text
        //Destroy(this.gameObject);
        // gameObject.SetActive(false);
    }
}
