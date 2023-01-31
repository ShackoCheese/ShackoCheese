using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame_Button : MonoBehaviour
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
        if((trigger.CompareTag("Player")&& oneIsIn == false) || (trigger.CompareTag("Platform") && oneIsIn == false))
        {
            button_active = true;
            oneIsIn = true;
            anim.SetFloat("Eneble", 1);
            a_s.Play();
        }
        else if((trigger.CompareTag("Player") && oneIsIn == true) || (trigger.CompareTag("Platform") && oneIsIn == true))
        {
            button_active = true;
            bothAreIn = true;
            oneIsIn = false;
            anim.SetFloat("Eneble", 1);
        }
    }

    void OnTriggerExit2D(Collider2D trigger)
    {
        if((trigger.CompareTag("Player")&& bothAreIn== true) || (trigger.CompareTag("Platform") && bothAreIn== true))
        {
            bothAreIn = false;
            oneIsIn = true;
        }
        else if((trigger.CompareTag("Player") && oneIsIn == true) || (trigger.CompareTag("Platform") && oneIsIn == true))
        {
            button_active = false;
            oneIsIn =false;
            anim.SetFloat("Eneble", 0);
        }
    }
    void update()
    {
        if(oneIsIn == true)
        {
            button_active = true;
        }
    }
}
