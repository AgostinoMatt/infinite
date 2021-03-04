using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("RunnerScene");
    }


    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }



    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void GoQuit()
    {
        Application.Quit();
    }
}
