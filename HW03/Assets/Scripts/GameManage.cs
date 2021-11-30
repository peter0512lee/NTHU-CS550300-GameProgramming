using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public GameObject WinUI;
    public GameObject LoseUI;
    public static int shootCount = 0;
    public AudioSource audioSource;
    public AudioSource WinAudioSource;


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Enemy: " + Enemy.EnemiesAlive);
    }
}
