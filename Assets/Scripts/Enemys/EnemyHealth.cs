using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : Health
{
    [SerializeField]
    private EnemyParameters enemyParameters;
    bool locker;

    void Start()
    {
        health = enemyParameters.Health;
        protection = enemyParameters.Protection;
    }

    public override void GetDamage(int damage)
    {
        base.GetDamage(damage);
    }

    public override void IfDeath()
    {
        if (health <= 0)
        {
            health = 0;
            if (!locker)
            {             
                    EnemySpawner.instance.EnemiesCurrentCount--;
                    finalEvent?.Invoke();
                    print("Death");
                    Destroy(this.gameObject, 1f);
                    EnemySpawner.instance.EnemiesBorn();
                    locker = true;                
            }
        }
    }
}
