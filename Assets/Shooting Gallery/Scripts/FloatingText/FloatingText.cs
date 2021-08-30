using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public Animator animator;
    private Text damageText;


    void OnEnable()
    {
        AnimatorClipInfo[] clipinfo = animator.GetCurrentAnimatorClipInfo(0);
        Debug.Log(clipinfo.Length);
        Destroy(gameObject, clipinfo[0].clip.length);
        damageText = animator.GetComponent<Text>();

    }

    public void SetText(string text)
    {
        damageText.text = text;

    }
}
