using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public bool GamePaused;
    public GameObject Panel;
    public AudioListener a_l;
    
    void Start()
    {
        GamePaused = false;
        Panel.SetActive(false);
        a_l = GameObject.Find("Main Camera").GetComponentInChildren<AudioListener>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused == true)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Panel.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        a_l.enabled = true;
    }

    public void Pause()
    {
        Panel.SetActive(true);
        a_l.enabled = false;
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
