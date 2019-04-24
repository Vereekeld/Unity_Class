using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip LevelMusic;
    public AudioSource musicSource;
    
    void Update()
    {
        musicSource.clip = LevelMusic;
        musicSource.Play();
    }
}
