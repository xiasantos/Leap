using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;


    private void Update()
    {
        if (Input.GetKeyDown("p")||Input.GetKeyDown("escape"))
        { pauseMenuUI.SetActive(true);
        }
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

    }
}
