using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    private float score = 0.0f;
    public Text HiScore;
    public bool isActive = true;

    

    // Update is called once per frame
    public void Update()
    {
        if (isActive)
        {
            score += Time.deltaTime;

        if (score > PlayerPrefs.GetFloat("HiScore", 0))
        {
            PlayerPrefs.SetFloat("HiScore", score);
        }
        }
    }

    public int GetScore()
    {
        return (int)Mathf.Floor(score);
    }

    public int GetHighScore()
    {
        return (int)Mathf.Floor(PlayerPrefs.GetFloat("HiScore",0));
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void SetActive()
    {
        isActive = false;
    }
}
