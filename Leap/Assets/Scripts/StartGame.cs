using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class StartGame : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public static event Action GameStarted;
    private bool gameRuning = false;
   

    private void Update()
    {
        if (gameRuning)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameRuning = true;
            textComponent.enabled = false;
            GameStarted?.Invoke();
          
        }

    }
}