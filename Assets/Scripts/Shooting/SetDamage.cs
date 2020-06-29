using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDamage : MonoBehaviour
{
    [SerializeField]
    private int damage;
    [SerializeField]
    private string tagName;
    public enum ChoiceTarget { Enemy, Player }
    public ChoiceTarget choiceTarget;  

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagName)
        {
            if(choiceTarget == ChoiceTarget.Enemy)
                other.GetComponent<EnemyHealth>().GetDamage(damage);
            else if(choiceTarget == ChoiceTarget.Player)
                other.GetComponent<HealthPlayer>().GetDamage(damage);
        }
    }
}
