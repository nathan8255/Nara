using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    //https://www.youtube.com/watch?v=6OT43pvUyfY&ab_channel=Brackeys

    public string name;
    public bool loop;

    public AudioClip clip;

    [Range (0f, 1f)]
    public float volume;
    [Range (0.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
