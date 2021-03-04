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

    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

<<<<<<< Updated upstream
=======
    public void ExitGame()
    {
        Application.Quit();
    }
>>>>>>> Stashed changes
}
