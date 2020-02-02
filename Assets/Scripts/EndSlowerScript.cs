using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSlowerScript : MonoBehaviour
{

    public GameObject runningWorld;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ant"))
        {
            StartCoroutine(nameof(SlowDown));
        }
    }

    IEnumerator SlowDown()
    {
        yield return new WaitForSeconds(0.4f);
        runningWorld.GetComponent<Conveyor>().speed /= 2;

    }
}
