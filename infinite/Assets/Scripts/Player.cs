using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    GameObject player;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float axis = Input.GetAxis("Horizontal");

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
