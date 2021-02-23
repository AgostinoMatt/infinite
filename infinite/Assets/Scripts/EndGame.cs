using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class EndGame : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Splat");
        //play splat anim

        Thread.Sleep(2000);
        SceneManager.LoadScene("GameOver");
    }
}
