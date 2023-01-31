using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timecounter : MonoBehaviour
{
    public float ido;
    public float maxido = 0;
    private float TimerPref;

    // Update is called once per frame
    void Update()
    {
        ido += Time.deltaTime;
    }

    public void SetFloat()
    {
        TimerPref = PlayerPrefs.GetFloat("GameTime");
        if(TimerPref != maxido)
        {
            maxido += ido+TimerPref;
        }
        else
        {
            maxido += ido;
        }
        PlayerPrefs.SetFloat("GameTime", maxido);
    }
}
