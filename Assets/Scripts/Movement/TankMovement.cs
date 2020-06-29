using UnityEditor;
using UnityEngine;

// Скрипт движения танка
public class TankMovement : MonoBehaviour
{
    private float movemenSpeed;
    private float rotationSpeed;
    private float moveTank;

    private void Start()
    {
        movemenSpeed = TankData.instance.tankParameters.Speed;
        rotationSpeed = TankData.instance.tankParameters.RotationSpeed;
    }

    void Update()
    {
        TankRotation();
        TankMove();
    }

    private void TankRotation()
    {
        moveTank = Input.GetAxis("Vertical");
        if (moveTank < 0)
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed * (-1), 0);
        else if (moveTank >= 0)
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
    }

    private void TankMove()
    {
        transform.Translate(0, 0, moveTank * Time.deltaTime * movemenSpeed * (-1));
    }
}