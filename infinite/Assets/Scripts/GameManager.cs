using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public Text scoreText;
    public Text highScoreText;

    [SerializeField]
    private float scoreCount;

    [SerializeField]
    private float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    [SerializeField]
    private float scoreMultiplier;

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

    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreTracker.Update();
        gameSpeed += speedIncrease * Time.deltaTime;


        scoreMultiplier = 1;
        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond * scoreMultiplier * Time.deltaTime;
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("Highscore", highScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        highScoreText.text = "Score " + Mathf.Round (highScoreCount);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50f, 50f, 100f, 50f), "Score: " + scoreTracker.GetScore());
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
        scoreIncreasing = false;

        gameSpeed = 1.0f;
        scoreTracker.ResetScore();
        StartCoroutine(DelayedLevelLoad(3.0f));

        scoreCount = 0;
        scoreIncreasing = true;
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
