using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void setvolme (float volume)
    {
        //Debug.Log(volume);
        audioMixer.SetFloat("Volume", volume);

    }
    public void setsfx (float volume)
    {
        //Debug.Log(volume);
        audioMixer.SetFloat("Sfx", volume);

    }
}
