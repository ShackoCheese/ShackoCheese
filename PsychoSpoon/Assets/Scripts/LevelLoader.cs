using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    public int AnimPlayed = 0;
    public gamemanager gm;
    public SpongeSaver Sp;
    public int CurrentLevel;
    public int unlockedlevels;

    
    void Awake()
    {
        unlockedlevels = PlayerPrefs.GetInt("Unlockedlvl");
    }
    void OnTriggerEnter2D(Collider2D box)
    {
        if(box.CompareTag("Player"))
        {   
            LevelUnlocked();
            //Elmenti, hogy a spongeok fel lettek-e véve
            PlayerPrefs.SetInt("lvl" + CurrentLevel + "s1", Sp.s1);
            PlayerPrefs.SetInt("lvl" + CurrentLevel + "s2", Sp.s2);
            PlayerPrefs.SetInt("lvl" + CurrentLevel + "s3", Sp.s3);
            LevelUnlocked();
            Loadnextlevel();
            GetCurrentScene();
            GetScore();
            if(GameObject.FindWithTag("GameController").GetComponent<gamemanager>().isPlateUsed == false && SceneManager.GetActiveScene().name == "World1lvl1" && PlayerPrefs.GetInt("Achivement_Gamer") == 0)
            {
                PlayerPrefs.SetInt("Achivement_Gamer", 1);
                PlayerPrefs.SetInt("GamerAchivementPlayer", 1);
                GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70043);
            }
        }
    }

    public void Loadnextlevel()
    {
        StartCoroutine(LoadLevel());
        GameObject.Find("GameManager").GetComponent<timecounter>().SetFloat();
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        
        yield return new WaitForSeconds(transitionTime);

        if(SceneManager.GetActiveScene().name == "W3lvl8"){
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70703);
            SceneManager.LoadScene("TheLastOne");
        }else{
            SceneManager.LoadScene("levelEnd");
        }
        
    }

    void GetCurrentScene()
    {
        PlayerPrefs.SetInt("currentscene", SceneManager.GetActiveScene().buildIndex);
        Level_Selector.Scene = SceneManager.GetActiveScene().buildIndex;
    }

    void GetScore()
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + gm.Score);
    }
    void LevelUnlocked() //Elmenti hogy kivitted a pályát
    {
            if(CurrentLevel > unlockedlevels)
            {
                PlayerPrefs.SetInt("Unlockedlvl", CurrentLevel);
            }
    }
}
