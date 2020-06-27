using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт для хранения параметров танка
[CreateAssetMenu(fileName = "New TankParameters", menuName = "TankParameters", order = 51)]
public class TankParameters : ScriptableObject
{
    [SerializeField]
    private int health;
    [SerializeField]
    private int protection;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed;

    public int Health     { get; set; }
    public int Protection { get; set; }
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public float RotationSpeed
    {
        get { return rotationSpeed;   }
        set { rotationSpeed = value;  }
    }
}
