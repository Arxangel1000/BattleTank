using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnPoints;
    [SerializeField]
    private GameObject[] enemyType;
    private int enemiesCount;

    void Start()
    {
        EnemiesBorn();
    }

    void Update()
    {
        
    }

    private void EnemiesBorn()
    {
        StartCoroutine(EnemiesBornWait());
    }

    IEnumerator EnemiesBornWait()
    {
        while (enemiesCount < 10)
        {
            int pointNumber = Random.Range(0, spawnPoints.Length);
            int enemyNumber = Random.Range(0, enemyType.Length);
            yield return new WaitForSeconds(3f);
            Instantiate(enemyType[enemyNumber], spawnPoints[pointNumber].transform.transform.position, Quaternion.identity);
            enemiesCount++;
        }
    }
}
