using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    private float score = 0.0f;

    // Update is called once per frame
    public void Update()
    {
        score += Time.deltaTime;
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
}
