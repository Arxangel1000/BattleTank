using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New EnemyParameters", menuName = "EnemyParameters", order = 52)]
public class EnemyParameters : ScriptableObject
{
    [SerializeField]
    private int health;
    [SerializeField]
    private float speed;
    [SerializeField]
    private int damage;
    [SerializeField]
    private float protection;

    public int Health { get {return health; }}
    public float Speed { get { return speed; }}
    public int Damage { get { return damage; }}
    public float Protection { get { return protection; }}


}
