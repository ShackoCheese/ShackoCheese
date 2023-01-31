using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableItem : MonoBehaviour
{
    //Változók felvétele.
    public Animator anim;
    public ParticleSystem ps;
    public gamemanager gm;
    public int pickedup;
    public AudioSource a_s;

    void Awake()
    {
        pickedup = 0;   
        a_s = GetComponent<AudioSource>();
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player") && pickedup == 0)
        {
            gm.ScoreUp();
            pickedup = 1;
            a_s.Play();
            DoTheThing();
        }
    }
   
    //Elindítja az animáció corutine-ját
    void DoTheThing()
    {
        StartCoroutine(delete());
    }


    IEnumerator delete()
    {   
        anim.SetFloat("Destroyed", 1f);
        yield return new WaitForSeconds(1);
        ps.Play();
        yield return new WaitForSeconds(1);
        pickedup = 0;
        Destroy(gameObject);
    } 
}
