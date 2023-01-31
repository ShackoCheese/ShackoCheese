using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandomiser : MonoBehaviour
{
   public AudioSource a1;
   public AudioSource a2;
   public AudioSource a3;
   private int sn;

    public void PlayRandomAudio()
    {
        sn = Random.Range(1, 4);
        if(sn == 1)
        {
            a1.Play();
        }
        if(sn == 2)
        {
            a2.Play();
        }
        else
        {
            a3.Play();
        }
    }
}
