using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float SpawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerupPrefab;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }

    

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-SpawnRange, SpawnRange);
        float spawnPosZ = Random.Range(-SpawnRange, SpawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameActive) return;
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount <= 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }

    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        {
            for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
        }
        
        
        
    }

}
