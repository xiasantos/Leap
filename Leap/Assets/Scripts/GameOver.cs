using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject toHide;
    public GameObject player;

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
        }
    }

    public void Restart()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
}
