using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGood : MonoBehaviour
{
    ScoreManager scoreManager;
    public int points;
    public CountHats countHatsObject;
    public PointAnimation pointAnimation;
    public GameObject pointTXT;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
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
            countHatsObject.AddCount(1);
            Instantiate(pointTXT, transform.position, transform.rotation);
            pointAnimation.Animate();
            Destroy(this.gameObject);
        }

    }
}
