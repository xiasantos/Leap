using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score;
    private GameObject player;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        if (player == null)
        { score += Time.fixedDeltaTime;
            scoreText.text = ((int)score).ToString();

        }
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}
