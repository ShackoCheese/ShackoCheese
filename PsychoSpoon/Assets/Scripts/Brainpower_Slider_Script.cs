using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brainpower_Slider_Script : MonoBehaviour
{
    public Brainpower myBrainpowerScript;
    public Slider slider;

    public void Update()
    {
        slider.value = myBrainpowerScript.brainpower;
        slider.maxValue = 100f;
    }
}
