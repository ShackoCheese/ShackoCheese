using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Víz : MonoBehaviour
{
    
    public GameObject WaterWave;
    public GameObject Wrsign;
    public Animator anim;
    public AudioSource a_s;

    
    void Start()
    {
        WaterWave.SetActive(false);
        Wrsign.SetActive(false);
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            a_s.Play();
            WaterWave.SetActive(true);
            Wrsign.SetActive(true);
            StartCoroutine(Animationer());
        }
    }
    IEnumerator Animationer()
    {
        yield return new WaitForSeconds(5);

        Wrsign.SetActive(false);
        anim.SetFloat("Water", 1);
        
        yield return new WaitForSeconds(1);
        
        WaterWave.SetActive(false);
        
    }
}
