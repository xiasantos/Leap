using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
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

        transform.position += new Vector3 (0, - cameraSpeed * Time.deltaTime, 0);
    }
}
