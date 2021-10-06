using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBorderObstacles : MonoBehaviour
{
    public List<GameObject> Obstacles;
    public GameObject borderLeft;
    public GameObject borderRight;
    public float maxY;
    public float minY;
    public float timebetweenSpawn;
    private float spawnTime;
    private List<float> positions;
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

    private void Start()
    {
        positions = new List<float>() {
            borderLeft.transform.position.x,
            borderRight.transform.position.x
        };
    }


    void Update()
    {
        if (!gameRuning)
        {
            return;
        }

        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timebetweenSpawn;
        }
    }

    void Spawn()
    {

        var randomY = Random.Range(minY, maxY);
        var index = Random.Range(0, positions.Count);
        var position = positions[index];
        var target = Obstacles[Random.Range(0, Obstacles.Count)];
        var result = Instantiate(
            target,
            transform.position + new Vector3(position, randomY, 0),
            transform.rotation
        );

        if(index ==1)
        {
           result.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
