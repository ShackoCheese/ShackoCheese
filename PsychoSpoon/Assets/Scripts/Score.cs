using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Image img;
    public gamemanager gm;
    public int scoreThreshold;

    void Start()
    {
        img.enabled = false;
    }

    void Update()
    {
        if(gm.Score == 0)
        {
            img.enabled = false;
        }

        if(gm.Score == scoreThreshold)
        {
            img.enabled = true;
        }
    }
}
