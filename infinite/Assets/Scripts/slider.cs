using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float floatSpeed = 1.0f;

    void Update()
    {
        Vector3 position = gameObject.transform.position;
        position.z -= moveSpeed * GameManager.Instance.GameSpeed * Time.deltaTime;
        position.z -= floatSpeed * Time.deltaTime;
        if (position.z > 4 || position.z < 2)
        {
            floatSpeed = floatSpeed * -1;
        }
        gameObject.transform.position = position;
    }

    public void StopMoving()
    {
        moveSpeed = 0;
        floatSpeed = 0;
    }
}
