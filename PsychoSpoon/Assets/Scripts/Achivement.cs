using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Achivement", menuName = "Achivements")]
public class Achivement : ScriptableObject
{
    public string name;
    public string description;

    public Sprite Image;
}
