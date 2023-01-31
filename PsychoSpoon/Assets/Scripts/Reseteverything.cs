using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseteverything : MonoBehaviour
{
    public GameObject Level_Selector;

    public void ResetTimeandSponge()
    {
        PlayerPrefs.SetFloat("GameTime", 0);
        PlayerPrefs.SetInt("lvl" + 1 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 1 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 1 + "s3", 0);
        PlayerPrefs.SetInt("lvl" + 2 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 2 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 2 + "s3", 0);
        PlayerPrefs.SetInt("lvl" + 3 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 3 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 3 + "s3", 0);
        PlayerPrefs.SetInt("lvl" + 4 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 4 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 4 + "s3", 0);
        PlayerPrefs.SetInt("lvl" + 5 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 5 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 5 + "s3", 0);
        PlayerPrefs.SetInt("lvl" + 6 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 6 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 6 + "s3", 0);
        PlayerPrefs.SetInt("lvl" + 7 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 7 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 7 + "s3", 0);
        PlayerPrefs.SetInt("lvl" + 8 + "s1", 0);
        PlayerPrefs.SetInt("lvl" + 8 + "s2", 0);
        PlayerPrefs.SetInt("lvl" + 8 + "s3", 0);
        PlayerPrefs.SetInt("score", 0);
        Level_Selector.GetComponent<Level_Selector>().Unlocked_Levels = 0;
        Level_Selector.GetComponent<Level_Selector>().Level1.interactable = true;
        Level_Selector.GetComponent<Level_Selector>().Level2.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level3.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level4.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level5.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level6.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level7.interactable = false;
        Level_Selector.GetComponent<Level_Selector>().Level8.interactable = false;
    }
}