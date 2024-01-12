using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer Master;
    public void SetVolume(float volume)
    {
        Master.SetFloat("volume", volume);
    }
}
