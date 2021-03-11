using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public static Settings instance;
    public AudioMixer soundMix;
    public float master;
    public float sfx;
    public float music;

    public void Start()
    {
        PlayerPrefs.SetFloat("musicVolume", 0);

        master = PlayerPrefs.GetFloat("Volume");
        sfx = PlayerPrefs.GetFloat("SFX");
        music = PlayerPrefs.GetFloat("MusicVolume");

        soundMix.SetFloat("masterVol", PlayerPrefs.GetFloat("Volume"));
        soundMix.SetFloat("sfxVol", PlayerPrefs.GetFloat("SFX"));
        soundMix.SetFloat("musicVol", PlayerPrefs.GetFloat("MusicVolume"));

    }

    public void Update()
    {
        master = PlayerPrefs.GetFloat("Volume");
        sfx = PlayerPrefs.GetFloat("SFX");
        music = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void SetMaster(float value)
    {
        soundMix.SetFloat("masterVol", value);
        PlayerPrefs.SetFloat("Volume", value);
        PlayerPrefs.Save();
    }
    public void GetMaster()
    {
        PlayerPrefs.GetFloat("MasterVolume");

    }
    public void SetSFX(float value)
    {
        soundMix.SetFloat("sfxVol", value);
        PlayerPrefs.SetFloat("SFXVolume", value);
        PlayerPrefs.Save();
    }
    public float GetSFX()
    {
        return PlayerPrefs.GetFloat("SFXVolume");
    }
    public float GetMusic()
    {
        return PlayerPrefs.GetFloat("MusicVolume");
    }
    public void SetMusic(float value)
    {
        soundMix.SetFloat("musicVol", value);
        PlayerPrefs.SetFloat("MusicVolume", value);
        PlayerPrefs.Save();
    }

    public void ResetVolumes()
    {
        PlayerPrefs.SetFloat("MasterVolume", 0);
        PlayerPrefs.SetFloat("SFXVolume", 0);
        PlayerPrefs.SetFloat("MusicVolume", 0);
        PlayerPrefs.Save();
        soundMix.SetFloat("masterVol", PlayerPrefs.GetFloat("MasterVolume"));
        soundMix.SetFloat("sfxVol", PlayerPrefs.GetFloat("SFXVolume"));
        soundMix.SetFloat("musicVol", PlayerPrefs.GetFloat("MusicVolume"));
    }

    public void MuteMusic(bool isMusic)
    {
        bool playmusic = isMusic;

        if (playmusic)
        {
            //SetMusic(0);
            soundMix.SetFloat("musicVol", -80);
            PlayerPrefs.SetFloat("MusicVolume", -80);
            PlayerPrefs.Save();
        }
        else
        {
            //SetMusic(-80);
            soundMix.SetFloat("musicVol", 0);
            PlayerPrefs.SetFloat("MusicVolume", 0);
            PlayerPrefs.Save();
        }
    }

    public void ResetHiScore()
    {
        PlayerPrefs.SetFloat("HiScore", 0);
    }
}
