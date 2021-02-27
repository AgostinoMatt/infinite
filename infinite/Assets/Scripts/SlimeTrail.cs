using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeTrail : MonoBehaviour
{
    public float speed = 1.0f;
    public float speedIncrease = 0.1f;

    // Update is called once per frame
    void Update()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var main = ps.main;
        main.simulationSpeed = speed += speedIncrease * Time.deltaTime;
    }
}
