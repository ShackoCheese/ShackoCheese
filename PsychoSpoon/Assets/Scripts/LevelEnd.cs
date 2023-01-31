using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    void Start()
    {
        if(PlayerPrefs.GetInt("Achivement_Gamer") == 1 && PlayerPrefs.GetInt("GamerAchivementPlayer") == 1)
        {
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Gamer");
            PlayerPrefs.SetInt("GamerAchivementPlayer", 0);
        }
    }

    public void Next_Level()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscene") + 1);
    }

    public void Retry()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscene"));
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
