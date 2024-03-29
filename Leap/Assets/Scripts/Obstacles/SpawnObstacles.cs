using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public List<GameObject> Obstacles;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetweenSpawn;
    private float spawnTime;
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

        if (Time.time >spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timebetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        GameObject target = Obstacles[Random.Range(0, Obstacles.Count)];
        Instantiate(target, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
