using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    GameObject player;

    private Animator anim;

    private void Start()
    {
        anim = this.GetComponentInChildren<Animator>();
    }

    private void FixedUpdate()
    {
        float axis = Input.GetAxis("Horizontal");



        if(axis >= 0.1)
        {
            anim.SetBool("right", true);
        }
        else if (axis <= -0.1)
        {
            anim.SetBool("left", true);
        }
        else
        {
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }

        if (axis != 0)
        {
            Vector3 pos = gameObject.transform.position;
            pos.x += axis * moveSpeed * Time.deltaTime;
            gameObject.transform.position = pos;
        }
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
    
}
