using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт для выбора оружия танка
public class ShootingController : MonoBehaviour
{
    private string shootingRegime;
    [SerializeField]
    private TankShooting[] tankShooting;
    private int currentNumber = 0;

    private void Start()
    {
        DisactivateAllGun();
    }
    private void Update()
    {
        GunChoice();
    }

    // метод для прогонки эллементов массива(орудий) в обе стороны
    private void GunChoice()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DisactivateAllGun();

            if (currentNumber > 0) { currentNumber -= 1; }
            else                   { currentNumber = tankShooting.Length - 1; }
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            DisactivateAllGun();

            if (currentNumber < tankShooting.Length-1) { currentNumber += 1; }
            else                                        { currentNumber = 0; }
        }

        tankShooting[currentNumber].enabled = true;
    }

    private void DisactivateAllGun()
    {
        foreach (var gun in tankShooting)
        {
            gun.enabled = false;
        }      
    }
    

}
