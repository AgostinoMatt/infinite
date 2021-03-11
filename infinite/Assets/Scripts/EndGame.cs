using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

public class EndGame : MonoBehaviour
{
    private GameObject player;
    private Animator anim;

    public AudioSource splatSound;

    private Player slimeSound;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Splat");
        player = GameObject.FindWithTag("Player");
        anim = player.GetComponentInChildren<Animator>();
        anim.SetBool("hit", true);

        //play splat anim
        GameManager.Instance.StopScore();
        GameManager.Instance.StopMoving();
        
        GameManager.Instance.speedIncrease = 0;
        player.GetComponent<Player>().moveSpeed = 0;

        player.GetComponentInChildren<AudioSource>().Stop();
        //endSlime.Stop();

        splatSound.Play();

        Invoke("loadGameover", 3);
    }

    public void loadGameover()
    {
        SceneManager.LoadScene("GameOver");
    }
}
