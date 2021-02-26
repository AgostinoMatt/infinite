using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTimer : MonoBehaviour
{
    public float timer;

    
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer >= 2)
        {
            this.gameObject.SetActive(false);
            timer = 0 + Time.deltaTime;
            Invoke("FireOn", 2);
        }
            
    }

    void FireOn()
    {
        this.gameObject.SetActive(true);
    }
}
