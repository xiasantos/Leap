using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject toHide;
    public GameObject player;
    public FinalScore finalScoreComponent;
    public TextMeshProUGUI scoreManagerComponent;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (player == null)
        {
            gameOverPanel.SetActive(true);
            toHide.SetActive(false);
            finalScoreComponent.SetScore(scoreManagerComponent.text);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
}
