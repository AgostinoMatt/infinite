using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
        Debug.Log(volume);
    }

    public void SetSFX (bool sfxToggle)
    {
        audioMixer.FindMatchingGroups("SFX");
        audioMixer.SetFloat("sfxVolume", 0);
        Debug.Log(sfxToggle);
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
