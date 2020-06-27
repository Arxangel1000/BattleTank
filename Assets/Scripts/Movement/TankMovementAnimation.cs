using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт проигрывает анимацию гусениц в зависимости от направления движения танка
public class TankMovementAnimation : DirectionMovement
{
    [SerializeField]
    private Animator animator;

    private void Start() {}

    private void Update()
    {
        СhassisBehavior();
    }

    public void СhassisBehavior()
    {
        switch (_DirectionMovement())
        {
            case 0  : animator.Play("Idle"); break;
            case 1  : animator.Play("ChassisLoopBack"); break;
            case -1 : animator.Play("ChassisLoopForward"); break;
        }
    }
}
