using UnityEditor;
using UnityEngine;

// Скрипт движения танка
public class TankMovement : MonoBehaviour
{
    private TankData tankData;
    private float movemenSpeed;
    private float rotationSpeed;


    private void Start()
    {
        tankData = GetComponent<TankData>();
        movemenSpeed = tankData.tankParameters.Speed;
        rotationSpeed = tankData.tankParameters.RotationSpeed;
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movemenSpeed * (-1));
    }
}