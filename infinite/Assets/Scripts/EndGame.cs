using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class EndGame : MonoBehaviour
{
    //private ScoreTracker scoreTracker = new ScoreTracker();
    public slider slide;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Splat");
        //play splat anim
        //scoreTracker.SetActive();
        //Thread.Sleep(2000);
        //SceneManager.LoadScene("GameOver");
        slide.moveSpeed = 0;
        slide.floatSpeed = 0;
        GameManager.Instance.speedIncrease = 0;
    }
}
