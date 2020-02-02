using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Image = UnityEngine.UI;

public class EndIntroScript : MonoBehaviour
{
    public SceneAsset scene;
    public Sprite[] images;
    public Image.Image image;
    public Image.Text buttonText;
    public Image.Text text;
    private int _nextIndex = 0;
    
    void Start()
    {
        if (images.Length < 1 || image == null)
        {
            throw  new UnityException("No Images attached");
        }

        text.text = "";

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
                buttonText.text = "";
                text.text = "Happy End";
            }
            image.sprite = images[_nextIndex++];   
        }
    }
}
