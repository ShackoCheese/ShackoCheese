using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost_Moveable : MonoBehaviour
{
    public Animator anim;
    public GameObject gm;
    public AudioSource a_S;

    void Awake()
    {
        gm = GameObject.FindWithTag("GameController");
        a_S = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("JumpBooster"))
        {
            PlayerPrefs.SetInt("Achivement_UnlimitedPowerJump", 1);
            gm.GetComponent<gamemanager>().disableSpeedBoost();
            gm.GetComponent<gamemanager>().enebleJumpBoost();
            gm.GetComponent<gamemanager>().platfromCameraEnabled = false;
            anim.SetFloat("sboosted", 0);
            anim.SetFloat("cboosted", 0);
            anim.SetFloat("jboosted", 1);
            a_S.Play();
        }

        if(col.CompareTag("SpeedBooster"))
        {
            PlayerPrefs.SetInt("Achivement_UnlimitedPowerSpeed", 1);
            gm.GetComponent<gamemanager>().disableJumpBoost();
            gm.GetComponent<gamemanager>().enebleSpeedBoost();
            gm.GetComponent<gamemanager>().platfromCameraEnabled = false;
            anim.SetFloat("jboosted", 0);
            anim.SetFloat("cboosted", 0);
            anim.SetFloat("sboosted", 1);
            a_S.Play();
        }
    
        if(col.CompareTag("CameraPot"))
        {
            PlayerPrefs.SetInt("Achivement_UnlimitedPowerCamera", 1);
            gm.GetComponent<gamemanager>().platfromCameraEnabled = true;
            anim.SetFloat("jboosted", 0);
            anim.SetFloat("sboosted", 0);
            anim.SetFloat("cboosted", 1);
            a_S.Play();
        }
        
        checksoupachivement();
    }

    void checksoupachivement()
    {
        if(PlayerPrefs.GetInt("Achivement_UnlimitedPowerJump") == 1 && PlayerPrefs.GetInt("Achivement_UnlimitedPowerSpeed") == 1 && PlayerPrefs.GetInt("Achivement_UnlimitedPowerCamera") == 1 && PlayerPrefs.GetInt("Achivement_UnlimitedPower") == 0)
        {
            PlayerPrefs.SetInt("Achivement_UnlimitedPower", 1);
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("UnlimitedPower");
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70042);
        }
    }
}
