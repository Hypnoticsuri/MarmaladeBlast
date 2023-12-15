using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] spawnPoints;
    public int enemyIndex;
   
   
    private float startDelay = 4;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnEnemy()
    {
       int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Transform spawnPos = spawnPoints[Random.Range(0, spawnPoints.Length)].transform;
        Instantiate(enemyPrefabs[enemyIndex], spawnPos.position, spawnPos.rotation);
    }
}
