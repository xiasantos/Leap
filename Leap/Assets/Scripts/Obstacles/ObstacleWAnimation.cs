using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleWAnimation : MonoBehaviour
{
    private GameObject player;
    private bool attacking;
    public AudioSource dieSound;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (attacking && collision.gameObject.CompareTag("Player"))
        {
            if (player != null)
            {
                dieSound.Play();
                Destroy(player);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(this.gameObject);
        }
    }

    public void Attack(int value)
    {
        attacking = Convert.ToBoolean(value);
    }
}
