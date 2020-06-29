using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : Health
{
    private HealthBar healthBar;
    private AudioSource audioDamage;

    private void Start()
    {
        health = TankData.instance.tankParameters.Health;
        protection = TankData.instance.tankParameters.Protection;
        healthBar = GetComponent<HealthBar>();
        audioDamage = GetComponent<AudioSource>();
    }

    public override void GetDamage(int damage)
    {
        healthBar.ChangeLine(damage);
        audioDamage.Play();
        base.GetDamage(damage);
    }

    public override void IfDeath()
    {
        base.IfDeath();
    }

}
