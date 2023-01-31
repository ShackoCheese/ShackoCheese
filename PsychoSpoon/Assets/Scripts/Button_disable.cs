using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_disable : MonoBehaviour
{
    public InGame_Button myInGame_ButtonScript;
    public InGameButtonLever Lever;
    [SerializeField]
    private GameObject Puzzle_Object;
    private int listlength;
    public bool on;
    public bool lever;

    void Update()
    {
        if(lever == false)
        {
            if(myInGame_ButtonScript.button_active == true && on == true)
            {
                Puzzle_Object.SetActive(false);
            }

            else if(myInGame_ButtonScript.button_active == false && on == true)
            {
               Puzzle_Object.SetActive(true);
            }

            else if(myInGame_ButtonScript.button_active == true && on == false)
            {
                Puzzle_Object.SetActive(true);
            }
            else if(myInGame_ButtonScript.button_active == false && on == false)
            {
                Puzzle_Object.SetActive(false); 
            }
        }
        else if(lever == true)
        {
            if(Lever.button_active == true && on == true)
            {
                Puzzle_Object.SetActive(false);
            }
            else if(Lever.button_active == true && on == false)
            {
                Puzzle_Object.SetActive(true);
            }
            else if(Lever.button_active == false && on == true)
            {
                Puzzle_Object.SetActive(true);  
            }
            else if(Lever.button_active == false && on == false)
            {
                Puzzle_Object.SetActive(false);
            }
        }
    }
}
