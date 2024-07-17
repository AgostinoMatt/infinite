using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    protected static MusicPlayer musicPlayer;


    private void Awake()
    {
        if (musicPlayer == null)
        {
            musicPlayer = this;
            DontDestroyOnLoad(musicPlayer);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
