using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Range(-1.0f, 1.0f)]
    public float xForceDirection = 0.0f;
    [Range(-1.0f, 1.0f)]
    public float yForceDirection = 0.0f;
    [Range(-1.0f, 1.0f)]
    public float zForceDirection = 0.0f;

    public float speedMultiplier = 1;

    public bool worldPivote = false;

    private Space spacePivot = Space.Self;

    private TankMovement tankMovement;

    void Start()
    {
        tankMovement = FindObjectOfType<TankMovement>();
        if (worldPivote) spacePivot = Space.World;
    }

    void Update()
    {
        this.transform.Rotate(xForceDirection * speedMultiplier, yForceDirection * speedMultiplier, zForceDirection * speedMultiplier, spacePivot);

        DirectionRotation(tankMovement.Direction, 0, 0); // меняем направление вращения колес в зависимости от хода танка
    }

    private void DirectionRotation(float x, float y, float z)
    {
        xForceDirection = x;
        yForceDirection = y;
        zForceDirection = z;
    }
}