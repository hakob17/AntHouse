using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class EndScript :  MonoBehaviour
{
    public SceneAsset sceneAsset;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ant"))
        {
            SceneManager.LoadScene(sceneAsset.name);
        }
    }
}