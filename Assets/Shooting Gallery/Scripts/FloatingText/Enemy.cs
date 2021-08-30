using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
    public int health;
    private int tempScore;
    private int tempKill;
    public Text ScoreText;
    public Text KillScore;

    //This is what's missing at the start on the video
    void Start()
    {
        FloatingTextController.Initialize();
    }

    public virtual void TakeDamage(int amount)
    {
        FloatingTextController.CreateFloatingText(amount.ToString(), transform);
        Debug.LogFormat("{0} was dealt {1} damage", gameObject.name, amount);
        int.TryParse(ScoreText.text, out tempScore);

        tempScore += amount;
        ScoreText.text = tempScore + "";
        if ((health -= amount) <= 0)
            Die();
    }


    public virtual void Die()
    {

        Debug.Log(gameObject.name + " has died.");
        int.TryParse(KillScore.text, out tempKill) ;
        tempKill += 1;
        KillScore.text = tempKill + "";
    DestroyObject(this.gameObject);
    }
    

}
