using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{

    public AudioSource audioSource;

    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Menu").GetComponent<Canvas>();
        canvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showMenu()
    {
        canvas.enabled = true;
    }

    public void hideMenu()
    {
        audioSource.Stop();
        canvas.enabled = false;
    }
}
