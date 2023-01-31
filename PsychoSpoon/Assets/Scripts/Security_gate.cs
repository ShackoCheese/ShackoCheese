using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Security_gate : MonoBehaviour
{
    public Collider2D Gate_Collider;
    public GameObject Player;
    public bool Blue_Gate;
    public bool Green_Gate;

    void Start()
    {
        //Gate_Collider = GetComponent<BoxCollider2D>();
        Gate_Collider.isTrigger = true;
        Player = GameObject.Find("Player");
    }

    void Update()
    {        
        if(Player.GetComponent<Brainpower>().brainpower_used == true)
        {
            if(Player.GetComponent<CharacterController2D>().JumpBoostEnabled == true && Green_Gate == true || Player.GetComponent<CharacterController2D>().SpeedBoostEnabled == true && Blue_Gate == true)
            {
                Gate_Collider.isTrigger = true;
            }
                
            else
            {
                Gate_Collider.isTrigger = false;
            }
        }

        else
        {
            Gate_Collider.isTrigger = true;
        }
    }
}
