using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameButtonLever : MonoBehaviour
{
    public bool button_active;
    public bool bothAreIn;
    public bool oneIsIn;
    public Animator anim;
    public AudioSource a_s;


    void Start()
    {
        a_s = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if((trigger.CompareTag("Player") && button_active == false) || (trigger.CompareTag("Platform") && button_active == false))
        {
            button_active = true;
            //oneIsIn = true;
            anim.SetFloat("Eneble", 1);
            a_s.Play();
        }
        else if((trigger.CompareTag("Player") && button_active == true) || (trigger.CompareTag("Platform") && button_active == true))
        {
            button_active = false;
            //bothAreIn = true;
            anim.SetFloat("Eneble", 0);
            a_s.Play();
        }
    }
    //void update()
    //{
    //    if(oneIsIn == true)
    //    {
    //        button_active = true;
    //    }
    //}
}
