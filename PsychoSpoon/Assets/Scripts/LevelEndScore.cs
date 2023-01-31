using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEndScore : MonoBehaviour
{
    [SerializeField]
    public Image Score1;
    [SerializeField]
    public Image Score2;
    [SerializeField]
    public Image Score3;
    public int score = 0;

    void Start()
    {
        Score1.enabled = false;
        Score2.enabled = false;
        Score3.enabled = false;
    }
    
    void Update()
    {
        score = PlayerPrefs.GetInt("lvlscore");

        if(score == 1)
        {
            Score1.enabled = true;
        }

        if(score == 2)
        {
            Score1.enabled = true;
            Score2.enabled = true;
        }

        if(score == 3)
        {
            Score1.enabled = true;
            Score2.enabled = true;
            Score3.enabled = true;
        }
    } 
}
