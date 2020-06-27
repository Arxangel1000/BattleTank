using UnityEngine;
public class TankMovement : MonoBehaviour
{
    [SerializeField]
    private TankParameters tankParameters;
    private float movementSpeed;
    [SerializeField]
    private float rotationSpeed = 200.0f;
    private int direction;

    public float MovementSpeed { get; set; }

    public float RotationSpeed
    {
        get { return rotationSpeed; }
    }

    public float Direction
    {
        get { return direction; }
        set { direction = (int)value;}
    }

    private void Start()
    {
        MovementSpeed = tankParameters.Speed;
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * RotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed * (-1));
        DirectionMovement();
    }

    public void DirectionMovement()
    {
        if (Input.GetAxis("Vertical") == 0)
            Direction = 0;
        else if (Input.GetAxis("Vertical") > 0)
            Direction = -1;
        else if (Input.GetAxis("Vertical") < 0)
            Direction = 1;
    }

}