using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class SoundClass 
{

    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    
    public bool loop;
    public bool PlayOnAwake;
    
    [Range(.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
