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
    public TextMeshProUGUI highScore;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (player == null)
        {
            gameOverPanel.SetActive(true);
            Cursor.visible = true;
            toHide.SetActive(false);
            finalScoreComponent.SetScore(scoreManagerComponent.text);
            highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
}
