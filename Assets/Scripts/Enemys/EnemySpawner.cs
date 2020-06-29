using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner instance;
    [SerializeField]
    private GameObject[] spawnPoints;
    [SerializeField]
    private GameObject[] enemyType;
    [SerializeField]
    private int enemiesBaseCount;
    private int enemiesCurrentCount;

    public int EnemiesCurrentCount { get { return enemiesCurrentCount; } set { enemiesCurrentCount = value; } }

    void Awake()
    {
        instance = this;        
    }

    void Start()
    {
        EnemiesBorn();
    }

    public void EnemiesBorn()
    {
        StartCoroutine(EnemiesBornWait());
    }

    IEnumerator EnemiesBornWait()
    {
        while (EnemiesCurrentCount < enemiesBaseCount)
        {
            int pointNumber = Random.Range(0, spawnPoints.Length);
            int enemyNumber = Random.Range(0, enemyType.Length);
            yield return new WaitForSeconds(3f);
            if (EnemiesCurrentCount < enemiesBaseCount)
            {
                Instantiate(enemyType[enemyNumber], spawnPoints[pointNumber].transform.transform.position, Quaternion.identity);
                enemiesCurrentCount++;
            }
        }
    }
}
