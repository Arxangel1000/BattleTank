using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт вращения камеры вокруг танка
public class OrbitCamera : MonoBehaviour
{
    [SerializeField]
    private Transform target; // Сериализовнная ссылка на объект вокруг которого производится облет

    public float rotSpeed = 1.5f;

    [SerializeField]
    private float _rotX;
    [HideInInspector]
    private float _rotY;
    [SerializeField]
    private float _rotZ;

    [SerializeField]
    private float distance;
    private Vector3 _offset;

    void Start()
    {
        _rotY = transform.eulerAngles.y;
        _offset = target.position - transform.position; // Сохранение начального смещения между камерой и целью
    }

    private void LateUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");
        _rotY += Input.GetAxis("Mouse X") * rotSpeed * 3; // или быстрый поворот с помощью мыши

        Quaternion rotation = Quaternion.Euler(_rotX, _rotY, _rotZ);
        transform.position = target.position - (rotation * _offset * distance); // Поддерживаем начальное смещение, сдвигаемое в соответствии с поворотом камеры
        transform.LookAt(target); // Камера всегда направлена на цель, где бы относительно этой цели она не располагалась.
    }
}

