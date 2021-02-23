using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("RunnerScene");// SceneManager.GetActiveScene().buildIndex + 1); <---- use that for incrementing levels
    }

    public void HighScores()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
