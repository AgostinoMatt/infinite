using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    const string MIXER_MUSIC = "musicVolume";
    const string MIXER_SFX = "sfxVolume";

    public float minVol = 0.0001f;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
        Debug.Log(volume);
    }

    public void SetSFX (bool sfxToggle)
    {
        if(sfxToggle)
        {
            audioMixer.SetFloat(MIXER_SFX, Mathf.Log10(1) * 20);
        }
        else
        audioMixer.SetFloat(MIXER_SFX, Mathf.Log10(minVol) * 20);
        Debug.Log(sfxToggle);
    }
    
    public void SetMusic (bool musicToggle)
    {
        if (musicToggle)
        {
            audioMixer.SetFloat (MIXER_MUSIC, Mathf.Log10(1) * 20);
        }
        else
        audioMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(minVol) * 20);
        Debug.Log(musicToggle);
    }

    public void ResetHiScore ()
    {
        PlayerPrefs.SetFloat("HiScore", 0);
    }

    public void LoadCredits ()
    {
        SceneManager.LoadScene("Credits");
    }
}
