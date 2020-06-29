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
    private float protection;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed;

    public int Health     { get { return health; }}
    public float Protection { get { return protection; } }
    public float Speed    { get { return speed; }}
    public float RotationSpeed { get { return rotationSpeed;}}
    
}
