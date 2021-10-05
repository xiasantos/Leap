using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject toHide;

   
    void Update()
    {
     if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
            toHide.SetActive(false);
        }
    }

    public void Restart()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
}
