using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{

    public AudioMixer audioMixer;
    public AudioMixer audioMixersfx;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Music", volume);
    }

    public void SetVolumeSFX(float sfxVolume)
    {
        audioMixersfx.SetFloat("Sfx", sfxVolume);
    }
}
