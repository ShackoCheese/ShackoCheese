using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public bool robotmozgas;

    void Start()
    {
        robotmozgas = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            robotmozgas = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider) 
    {
        if(collider.CompareTag("Player"))
        {
            robotmozgas = false;
        }
    }
}
