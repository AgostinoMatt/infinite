using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class EndGame : MonoBehaviour
{
    //private ScoreTracker scoreTracker = new ScoreTracker();
    //private slider slide;
    //public Player player;

    public GameObject slide;
    public GameObject player;

    void Awake()
    {
        //slide = GetComponentInParent<slider>();
    }

    private void Start()
    {
        //GameObject[] slide;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Splat");
        //play splat anim
        //scoreTracker.SetActive();
        //Thread.Sleep(2000);
        //SceneManager.LoadScene("GameOver");
        slide = GameObject.FindWithTag("Level").GetComponent(slider);
        player = GameObject.FindWithTag("Player").GetComponent(Player);

        
        slide.moveSpeed = 0;
        slide.floatSpeed = 0;
        GameManager.Instance.speedIncrease = 0;
        player.moveSpeed = 0;
    }
}
