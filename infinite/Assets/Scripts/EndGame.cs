using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

public class EndGame : MonoBehaviour
{
    private slider slide;
    public ScoreTracker scoreTracker;

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
        //scoreTracker.isActive = false;
        GameManager.Instance.StopScore();
        
        player = GameObject.FindWithTag("Player");

        GameManager.Instance.StopMoving();
        
        GameManager.Instance.speedIncrease = 0;
        player.GetComponent<Player>().moveSpeed = 0;
    }
}
