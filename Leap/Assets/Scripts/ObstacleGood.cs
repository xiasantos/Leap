using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGood : MonoBehaviour
{
    ScoreManager scoreManager;
    public int points;
    public GameObject crunchAudio;
    private AudioSource aS;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        aS = crunchAudio.GetComponent<AudioSource>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            scoreManager.AddScore(points);

            Destroy(this.gameObject);
            aS.Play();

        }

    }
}
