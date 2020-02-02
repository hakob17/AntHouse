using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset; 
    private void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
//        Vector2 pos = Vector2.Lerp(target.transform.position, offset, 0.02f);
        transform.position = target.transform.position + offset;
    }
}
