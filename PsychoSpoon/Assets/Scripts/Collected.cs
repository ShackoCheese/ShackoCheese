using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collected : MonoBehaviour
{
    public int collected;
    public Text txt;
    public int MaxSponge;
    public bool medalUnlocked;

    void Start()
    {
        collected = PlayerPrefs.GetInt("score");
        txt.text = "Collected: " + collected.ToString() + "/" +MaxSponge.ToString();
        
        if(collected >= MaxSponge)
        {
            txt.text = "Collected: "  + MaxSponge.ToString() + "/" + MaxSponge.ToString();
        }
    }
}
