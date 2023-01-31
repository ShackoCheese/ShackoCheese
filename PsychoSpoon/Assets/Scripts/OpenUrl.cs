using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{

    public void DoTheThing()
    {
        Application.OpenURL("https://forms.gle/pukhkaDHMSTie284A");
        //GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(66540);
        Debug.Log("is this working?");
    }
}
