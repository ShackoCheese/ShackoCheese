using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDeath : MonoBehaviour
{
    public gamemanager mygamemanagerScript;
    [SerializeField]
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
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
}