using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAlongX : MonoBehaviour
{
    private Transform referencePoint;
    public float pointOfNoReturn = -50f;

    void Start()
    {
        referencePoint = Camera.main.transform;
    }


    void Update()
    {
        if (referencePoint.position.z - gameObject.transform.position.z > pointOfNoReturn)
        {
            Destroy(gameObject);
        }
    }
}
