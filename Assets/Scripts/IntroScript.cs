using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Image = UnityEngine.UI;

public class IntroScript : MonoBehaviour
{
    // Start is called before the first frame update

    public SceneAsset scene;
    public Sprite[] images;
    public Image.Image image;
    public Image.Text buttonText;
    private int _nextIndex = 0;
    
    void Start()
    {
        if (images.Length < 1 || image == null)
        {
            throw  new UnityException("No Images attached");
        }

        image.sprite = images[_nextIndex++];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNext()
    {
        if (_nextIndex == images.Length)
        {
            SceneManager.LoadScene(scene.name);
        }
        else 
        {
            if (_nextIndex == images.Length - 1)
            {
                buttonText.text = "Play";
            }
            image.sprite = images[_nextIndex++];   
        }
    }
}
