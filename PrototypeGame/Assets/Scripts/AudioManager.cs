using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
        }
    }

    public void Play (string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
