using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conveyor : MonoBehaviour
{
    public float speed = 5f;
    private bool _started;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_started)
        {
            transform.position += Time.deltaTime * speed * Vector3.right;
        }

        StartCoroutine(nameof(WaitAWhile));
    }

    IEnumerator WaitAWhile()
    {
        yield return new WaitForSeconds(2);
        _started = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ant"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}