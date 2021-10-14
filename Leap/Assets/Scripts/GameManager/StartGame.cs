using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class StartGame : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject star;
    public GameObject pause;
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
            pause.SetActive(true);
            star.SetActive(false);
            textComponent.enabled = false;
            GameStarted?.Invoke();
            playerAnimator.enabled = true;
        }
    }
}