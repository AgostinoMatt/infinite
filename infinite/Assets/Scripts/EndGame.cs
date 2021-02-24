using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class EndGame : MonoBehaviour
{
    //private ScoreTracker scoreTracker = new ScoreTracker();
    private slider slide;
    //public Player player;

    void Awake()
    {
        //slide = GetComponent<slider>();
        slide = GetComponentInParent<slider>();
    }

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
        Player.Instance.moveSpeed = 0;
    }
}
