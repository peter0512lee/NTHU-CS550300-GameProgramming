using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public Dropdown dropDown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleMuteOption(bool toggle)
    {
        audioSource.mute = toggle;
    }

    public void ModifyVolume(float vol)
    {
        audioSource.volume = vol;
    }

    public void AudioChange()
    {
        int currentValue = dropDown.value;
        if (currentValue == 0)
        {
            audioSource.clip = audioClip1;
        }
        else
        {
            audioSource.clip = audioClip2;
        }

        audioSource.Play();
    }
}
