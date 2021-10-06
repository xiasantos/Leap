using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopingbackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    private bool gameRuning;

    private void OnEnable()
    {
        StartGame.GameStarted += OnStartGame;
    }

    private void OnDisable()
    {
        StartGame.GameStarted -= OnStartGame;
    }

    private void OnStartGame()
    {
        gameRuning = true;
    }

    void Update()
    {
        if (!gameRuning)
        {
            return;
        }

        backgroundRenderer.material.mainTextureOffset += new Vector2(0f, - backgroundSpeed * Time.deltaTime);
    }
}
