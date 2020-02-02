using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbWater : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("water"))
        {
            StartCoroutine(Absorb(other.gameObject));
        }
    }

    IEnumerator Absorb(GameObject water)
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(water);
    }
}
