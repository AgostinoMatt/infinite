using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    private float score = 0.0f;
    public float tempScore = 0;
    public bool isActive = true;

    // Update is called once per frame
    public void Update()
    {
        tempScore = score;
        if (isActive)
        {
            score += Time.deltaTime;
        }
        else
        {
            score = tempScore;
        }
            //Debug.Log(GetScore());
    }

    public int GetScore()
    {
        return (int)Mathf.Floor(score);
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
