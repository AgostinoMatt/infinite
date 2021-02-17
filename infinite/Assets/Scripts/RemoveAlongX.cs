using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAlongX : MonoBehaviour
{
    private Transform referencePoint;
    public float pointOfNoReturn = 0f;

    // Use this for initialization
    void Start()
    {
        referencePoint = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (referencePoint.position.z - gameObject.transform.position.z > pointOfNoReturn)
        {
            Destroy(gameObject);
        }
    }
}
