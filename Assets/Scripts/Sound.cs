using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound {


    //Adding the name of the name of the sound to the AudioManager inspector.
    public string name;

    // Adding the possibility to add a clip of sound/sound to the AudioManager inspector.
    public AudioClip clip;

    //Adding volume and its range  to the AudioManager inspector.
    [Range(0f, 1f)]
    public float volume;

    // Adding pitch and its range to the AudioManager inspector.
    [Range(.1f, 3f)]
    public float pitch;


    //Audio Source will be hidden in inspector.
    [HideInInspector]
    public AudioSource source;


}
