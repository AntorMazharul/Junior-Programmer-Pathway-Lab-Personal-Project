using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject powerupPrefab;
    private float posX = 10.0f;
    private float posY = 0.75f;
    private float posZ = 5.0f;
    private float timeDelay = 2.0f;
    private float timeIntervalEnemy = 2.0f;
    private float timeIntervalPoweup = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemyObjects", timeDelay, timeIntervalEnemy);
        InvokeRepeating("SpawnPowerup", timeDelay, timeIntervalPoweup);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemyObjects()
    {
        float randomRangeX = Random.Range(-posX, posX);
        int randomPrefab = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[randomPrefab], new Vector3(randomRangeX, posY, posZ), enemyPrefabs[randomPrefab].transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomRangeX = Random.Range(-posX, posX);

        Instantiate(powerupPrefab, new Vector3(randomRangeX, posY, posZ), powerupPrefab.transform.rotation);
    }
}
