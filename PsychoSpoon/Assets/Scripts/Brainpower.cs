using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Brainpower : MonoBehaviour
{
    public float brainpower;
    public bool brainpower_used;
    public float timer;
    public float recharge;
    public float cost = 1.8f;
    public Animator animator;
    public AudioSource a_s;
    public Rigidbody2D rb;

    public gamemanager mygamemanagerScript;

    void Start()
    {
        a_s = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        recharge = 3f;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    { 

        if(mygamemanagerScript.platformMovementEnabled == true)
        {
            Brainpower_Activated();
        }

        else
        {
            brainpower_used = false;
            animator.SetBool("Activated", false);
        }

        if(brainpower == 100)
        {
            timer = 0f;
        }

        if(brainpower <= 0)
        {
            if(SceneManager.GetActiveScene().name == "World1lvl1" && PlayerPrefs.GetInt("Achivement_FirstLevelDeath") == 0)
            {
                PlayerPrefs.SetInt("Achivement_FirstLevelDeath", 1);
                GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("FirstLevelDeath");
                GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70039);
            }
            mygamemanagerScript.Respawn();
        }
    }

    void FixedUpdate()
    {
        if(brainpower_used == false)
        {
           Reload();
        }
    }

    void Reload()
    {
        a_s.Play();
        timer +=  0.016f;
        if(timer >= 0.5f && brainpower_used == false)
        {
            brainpower += Mathf.Sqrt(recharge * Time.deltaTime);
            if(brainpower >= 100)
            {
                brainpower = 100f;
            }
        }
    }

    void Brainpower_Activated()
    {
        brainpower -= Mathf.Sqrt(cost * Time.deltaTime);
        brainpower_used = true;
        timer = 0f;
        animator.SetFloat("Brainpower", brainpower);
        animator.SetBool("Activated", true);
        if (SceneManager.GetActiveScene().name == "World1lvl1" && PlayerPrefs.GetInt("Achivement_Gamer") == 0 && PlayerPrefs.GetInt("GamerAchivementPlayer") == 1)
        {
            PlayerPrefs.SetInt("Achivement_Gamer", 1);
            PlayerPrefs.SetInt("GamerAchivementPlayer", 0);
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Gamer");
        }
    }

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.CompareTag("Platform") && mygamemanagerScript.playerMovementEnabled == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX & RigidbodyConstraints2D.FreezePositionY;
        }

        if(trigger.CompareTag("TheEnd"))
        {
            StartCoroutine(Backtotitle());
        }
    }

    IEnumerator Backtotitle()
    {
        GameObject.FindWithTag("EndCam").SetActive(true);
        yield return new WaitForSeconds(5);
        GameObject.FindWithTag("EndCam").SetActive(false);
    }
}