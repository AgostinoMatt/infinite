using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{

    void FixedUpdate()
    {
        Vector3 position = gameObject.transform.position;
        position.z -= GameManager.Instance.moveSpeed * GameManager.Instance.GameSpeed * Time.deltaTime;
        //position.z -= GameManager.Instance.floatSpeed * Time.deltaTime;
        if (position.z > 4 || position.z < 2)
        {
            GameManager.Instance.floatSpeed = GameManager.Instance.floatSpeed * -1;
        }
        gameObject.transform.position = position;
    }
    
}
