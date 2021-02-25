using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

public class EndGame : MonoBehaviour
{
    //private ScoreTracker scoreTracker = new ScoreTracker();
    private slider slide;
    //public Player player;

    public GameObject[] slides;
    public GameObject player;

    void Awake()
    {
        slide = GetComponentInParent<slider>();
    }

    private void Start()
    {
        //GameObject[] slide;
        slides = GameObject.FindGameObjectsWithTag("Level");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Splat");
        //play splat anim
        //scoreTracker.SetActive();
        
        player = GameObject.FindWithTag("Player");

        GameManager.Instance.StopMoving();
        
        GameManager.Instance.speedIncrease = 0;
        player.GetComponent<Player>().moveSpeed = 0;
    }
}
