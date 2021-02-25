using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

public class EndGame : MonoBehaviour
{
    public GameObject player;


    void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Splat");
        //play splat anim
        GameManager.Instance.StopScore();
        GameManager.Instance.StopMoving();
        player = GameObject.FindWithTag("Player");
        GameManager.Instance.speedIncrease = 0;
        player.GetComponent<Player>().moveSpeed = 0;

        Invoke("loadGameover", 3);
    }

    public void loadGameover()
    {
        SceneManager.LoadScene("GameOver");
    }
}
