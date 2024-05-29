using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public Vector2 spawnPoint;
    public GameObject[] enemysPrefabs;
    int randomEnemy;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Debug.Log("spawn");
        //get random spawn ponts
        spawnPoint.x = Random.Range(minX, maxX);
        spawnPoint.y = Random.Range(minY, maxY);
        randomEnemy = Random.Range(0, enemysPrefabs.Length);
        Instantiate(enemysPrefabs[randomEnemy], spawnPoint, Quaternion.identity);
    }
}