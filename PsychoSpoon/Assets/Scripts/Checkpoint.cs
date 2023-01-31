using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public gamemanager mygamemanagerScript;
    public Animator myAnimator;
    public ParticleSystem ps;
    public ParticleSystem activatedps;
    public AudioSource a_s;
    public bool activeted;
    public int Checkpoint_id;
    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        activeted = false;
        a_s = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D box)
    {
        if(box.CompareTag("Player") && activeted == false)
        {
            a_s.Play();
            mygamemanagerScript.Activated_Checkpoint_id = Checkpoint_id;
            myAnimator.SetFloat("active", 1);
            ps.Play();
            activeted = true;
            activatedps.Play();
        }
    }
}
