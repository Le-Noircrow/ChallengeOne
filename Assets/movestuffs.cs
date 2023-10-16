using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movestuffs : MonoBehaviour
{
    public Animator anim, practice;

    // Start is called before the first frame update
    void Start()
    {
        practice.GetComponent<Animator>();
        anim.GetComponent<Animator>();
    }

    public void Slide()
    {
        anim.SetBool("Slide", true);
    }

    public void Practice()
    {
        practice.SetBool("Practice", true);
    }
}
