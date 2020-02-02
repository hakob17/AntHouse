using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Camera : MonoBehaviour
{
    [FormerlySerializedAs("target")] public GameObject target;
    private Vector3 offset; 
    private void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        
        transform.position = target.transform.position + offset;
    }
}
