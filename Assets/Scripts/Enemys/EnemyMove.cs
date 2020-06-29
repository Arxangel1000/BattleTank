using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private EnemyParameters enemyParameters;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.speed = enemyParameters.Speed;
    }
}
