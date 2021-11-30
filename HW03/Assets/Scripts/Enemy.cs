using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 4f;
    public static int EnemiesAlive = 0;
    public GameObject WinUI;
    public AudioSource audioSource;

    void Start()
    {
        EnemiesAlive++;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }

    void Die()
    {
        EnemiesAlive--;
        Destroy(gameObject);
        audioSource.Play();
    }
}
