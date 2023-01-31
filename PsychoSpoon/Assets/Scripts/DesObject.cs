using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesObject : MonoBehaviour
{
    public gamemanager gm;
    [SerializeField]
    public GameObject Player;
    [SerializeField]
    public GameObject Spike;

    public Animator am;
    public Animator slider_anim;
    public bool active;
    public float downtime;
    public AudioSource a_s;
    public bool button;
    public InGameButtonLever igbl;
    public InGame_Button Igb;

    void awake()
    {
        am = GetComponent<Animator>();
        a_s = GetComponent<AudioSource>();
    }
    
    void Start()
    {
        am = GetComponent<Animator>();
        a_s = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(button == true)
        {
            if(igbl.button_active == true || Igb.button_active == true)
            {
                a_s.Pause();
                Spike.SetActive(false); 
                am.SetFloat("Active", 0);
            }
            else if(igbl.button_active == false || Igb.button_active == true)
            {
                a_s.Play();
                Spike.SetActive(true); 
                am.SetFloat("Active", 1);
            }
        }
        else if(Input.GetKeyDown("e") && active == false)
        {
            active = true;
            a_s.Pause();
            Spike.SetActive(false); 
            am.SetFloat("Active", 0);
            StartCoroutine(anim());
        }

        //if(Timeractive == true)
        //{
        //    Somatimer = Somatimer + 0.01f; 
        //}
//
        //if(Somatimer >= downtime)
        //{
        //    Somatimer = 0f;
        //    Timeractive = false;
        //    Spike.SetActive(true);
        //    am.SetFloat("Active", 1);
        //    slider_anim.SetFloat("Activate", 0); 
        //    a_s.PlayDelayed(1);
        //}
    }

    IEnumerator anim()
    {
        yield return new WaitForSeconds(1);
        slider_anim.SetFloat("Activate", 1);
        yield return new WaitForSeconds(downtime);
        am.SetFloat("Active", 1);
        slider_anim.SetFloat("Activate", 0);
        Spike.SetActive(true);
        yield return new WaitForSeconds(1);
        a_s.Play();
        active = false;
    }
}
