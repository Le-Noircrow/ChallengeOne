using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator anim, leftFlapAnim, rightFlapAnim;
    public GameObject modesButton, flap;
    
    public void Start()
    {
        anim.GetComponent<Animator>();
        leftFlapAnim.GetComponent<Animator>();
        rightFlapAnim.GetComponent<Animator>();
    }
    public void FlipSquare()
    {
        anim.SetBool("Flip", true);

        StartCoroutine(TimerG());
        IEnumerator TimerG()
        {
            yield return new WaitForSeconds(1);
            anim.SetBool("Flip", false);
        }
        StartCoroutine(Timer());
        IEnumerator Timer()
        {
            yield return new WaitForSeconds(2);
            modesButton.SetActive(false);
            leftFlapAnim.SetBool("Open", true);
            rightFlapAnim.SetBool("RightFlip", true);
            anim.SetBool("Flip", true);
            flap.SetActive(false);
        }
    }
}
