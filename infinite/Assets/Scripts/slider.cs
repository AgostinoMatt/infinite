using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float floatSpeed = 1.0f;

    //public object GameManager { get; private set; }

    // Update is called once per frame
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
}
