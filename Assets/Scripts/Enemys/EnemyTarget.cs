using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTarget : MonoBehaviour
{
    private Transform target;
    private Rigidbody rb;
    private NavMeshAgent agent;

    void Start()
    {
        target = TankData.instance.playerTank;
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}
