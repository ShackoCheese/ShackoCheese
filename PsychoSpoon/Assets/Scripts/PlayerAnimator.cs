using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;

    private void Awke()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
           animator.SetFloat("Speed", 1f);
           animator.SetFloat("Horizontal", -1f);
        }
        
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
           animator.SetFloat("Horizontal", 1f);
           animator.SetFloat("Speed", 1f);
        }
        if(Input.GetKey(KeyCode.E))
        {
            animator.SetFloat("Horizontal", 0f);
            animator.SetFloat("Speed", 0f); 
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("secret"))
        {
            animator.SetBool("Egg", true);
            if(PlayerPrefs.GetInt("Achivement_spoonflip") == 0)
            {
                PlayerPrefs.SetInt("Achivement_spoonflip", 1);
                GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Spoonflip");
                GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70693);
            }
        }
    }
    
    void FixedUpdate()
    {
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Speed", 0);
        animator.SetBool("Egg", false);
    }
}
