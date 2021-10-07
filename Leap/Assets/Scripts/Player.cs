using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rb;
    private Vector2 playerDirection;
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

        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, 0).normalized;
    }

   
    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * playerSpeed, 0);
    }
}
