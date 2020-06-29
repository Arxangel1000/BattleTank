using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    protected int health;
    [SerializeField]
    protected float protection;
    [SerializeField]
    protected UnityEvent finalEvent;

    public int _Health { get { return health;} }
    public float Protection { get { return protection;} }

    public virtual void GetDamage(int damage)
    {
        health -= (int)(damage * protection);
        IfDeath();
    }

    public virtual void IfDeath()
    {
        if (health < 0)
        {
            health = 0;
            finalEvent?.Invoke();
            Destroy(this.gameObject, 2f);
        }
    }
}
