using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public static GameManager Instance { get { return instance; } }

    public float speedIncrease = 0.1f;
    private float gameSpeed = 1.0f;

    public float moveSpeed = 10f;
    public float floatSpeed = 1.0f;

    public float GameSpeed { get { return gameSpeed; } }

    private ScoreTracker scoreTracker = new ScoreTracker();

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
        moveSpeed = 10;
        floatSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTracker.Update();
        gameSpeed += speedIncrease * Time.deltaTime;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50f, 50f, 100f, 50f), "Score: " + scoreTracker.GetScore());
    }

    public float GetScore()
    {
        return scoreTracker.GetScore();
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
