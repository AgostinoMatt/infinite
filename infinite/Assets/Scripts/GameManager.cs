﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public static GameManager Instance { get { return instance; } }

    public float speedIncrease = 0.2f;
    private float gameSpeed = 1.0f;

    public float moveSpeed = 10f;
    public float floatSpeed = 1.0f;

    public float GameSpeed { get { return gameSpeed; } }

    public ScoreTracker scoreTracker;

    public Text scoreText;
    public Text highScoreText;
    public Text highScore;

    private GUIStyle style = new GUIStyle();

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        gameSpeed += speedIncrease * Time.deltaTime;
    }

    void OnGUI()
    {
        style.fontSize = 40;
        style.normal.textColor = Color.white;
        GUI.Label(new Rect(50f, 100f, 100f, 50f), "Score: " + scoreTracker.GetScore(), style);
        GUI.Label(new Rect(50f, 50f, 100f, 50f), "Hi-Score: " + scoreTracker.GetHighScore(), style);
    }

    public float GetScore()
    {
        return scoreTracker.GetScore();
    }

    public void StopScore()
    {
        scoreTracker.SetActive();
    }
   

    public void SlowSpeed(float modifier)
    {
        gameSpeed -= modifier;

        if (gameSpeed < 1f)
        {
            gameSpeed = 1f;
        }
    }

    public void AddSpeed(float modifier)
    {
        gameSpeed += modifier + 2f;
    }

    public void RestartLevel()
    {
        gameSpeed = 1.0f;
        scoreTracker.ResetScore();
        StartCoroutine(DelayedLevelLoad(3.0f));

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StopMoving()
    {
        moveSpeed = 0;
        floatSpeed = 0;
    }

    IEnumerator DelayedLevelLoad(float delay)
    {
        Time.timeScale = 0.1f;
        float delayStartTime = Time.realtimeSinceStartup;

        while (delay >= Time.realtimeSinceStartup - delayStartTime)
        {
            yield return 0;
        }

        Time.timeScale = 1.0f;

        SceneManager.LoadScene(0);

    }
}
