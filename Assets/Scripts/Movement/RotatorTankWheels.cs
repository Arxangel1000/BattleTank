using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт для вращения колес танка
public class RotatorTankWheels : DirectionMovement
{
    private Rotator rotator;

    public enum LeftOrRightChasing { left, right };
    public LeftOrRightChasing leftOrRightChasing = LeftOrRightChasing.left;

    void Start()
    {
        rotator = GetComponent<Rotator>();
    }

    void Update()
    {
        DirectionRotationActive();
    }

    private void DirectionRotation(float x, float y, float z)
    {
        rotator.XForceDirection = x;
        rotator.YForceDirection = y;
        rotator.ZForceDirection = z;
    }

    private void DirectionRotationActive()
    {
        if (leftOrRightChasing == LeftOrRightChasing.left)
            DirectionRotation(_DirectionMovement(), 0, 0); // меняем направление вращения колес в зависимости от хода танка
        else if (leftOrRightChasing == LeftOrRightChasing.right)
            DirectionRotation(_DirectionMovement() * -1, 0, 0);
    }
}
