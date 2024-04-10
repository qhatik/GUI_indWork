using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume;

    public Slider volumeSlider;

    private const string volumeKey = "MusicVolume";

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        musicVolume = PlayerPrefs.GetFloat(volumeKey, 1f);
        audioSrc.volume = musicVolume; 
        volumeSlider.value = musicVolume; 
    }

    void Update()
    {
        audioSrc.volume = musicVolume; 
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat(volumeKey, musicVolume); 
    }
}
