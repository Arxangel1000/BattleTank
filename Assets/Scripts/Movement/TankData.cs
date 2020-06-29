using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт доступа к хранилищу данных по танку
public class TankData : MonoBehaviour
{
    public static TankData instance;
    [HideInInspector]
    public Transform playerTank;
    public TankParameters tankParameters;

    private void Awake()
    {
        instance = this;
        playerTank = transform;
    }
}
