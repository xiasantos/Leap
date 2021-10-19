using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public AudioSource dieSound;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.gameObject.CompareTag("Player"))
        {
                dieSound.Play();
                Destroy(player);
        }

        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(this.gameObject);
        }

    }
}

