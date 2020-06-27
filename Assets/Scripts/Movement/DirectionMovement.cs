using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт для определения направления движения танка по нажатию на стрелки клавиатуры
public class DirectionMovement : MonoBehaviour
{
    private int direction;

    public float Direction
    {
        get { return direction; }
        set { direction = (int)value; }
    }

    public int _DirectionMovement()
    {
        if (Input.GetAxis("Vertical") == 0)
            Direction = 0;
        else if (Input.GetAxis("Vertical") > 0)
            Direction = -1;
        else if (Input.GetAxis("Vertical") < 0)
            Direction = 1;

        return (int)Direction;
    }

    private void Update()
    {
        _DirectionMovement();
    }
}
