using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D hook;
    public GameObject nextBall;
    public GameObject WinUI;
    public GameObject LoseUI;
    public Text shootCountText;
    public Text scoreText;
    public float releaseTime = 0.15f;
    public float maxDragDistance = 2f;
    private bool isPressed = false;
    public AudioSource audioSource;
    public AudioSource BGMAudioSource;
    public AudioSource LoseAudioSource;
    public AudioSource WinAudioSource;


    void Start()
    {

    }

    void Update()
    {
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
            else
                rb.position = mousePos;
        }

        shootCountText.text = "Shoot: " + GameManage.shootCount + "/3";
        scoreText.text = "Score: " + (4 - GameManage.shootCount) * 100;
    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        GameManage.shootCount++;
        audioSource.Play();
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(3f);

        if (nextBall != null)
        {
            nextBall.SetActive(true);
        }

        if (GameManage.shootCount == 3 && Enemy.EnemiesAlive != 0)
        {
            Debug.Log("You Lose!");
            LoseUI.SetActive(true);
            BGMAudioSource.Stop();
            LoseAudioSource.Play();
        }

        if (Enemy.EnemiesAlive <= 0)
        {
            Debug.Log("You Win!");
            WinUI.SetActive(true);
            BGMAudioSource.Stop();
            WinAudioSource.Play();
        }
    }
}
