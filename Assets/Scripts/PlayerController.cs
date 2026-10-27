using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Edit straight line speed and turning speed
    public float speed = 5.0f;
    public float turnSpeed;

    // Input Action kept public for selection of input keys (WASD)
    public InputAction moveAction;

    // private input values read from input action (x,y)
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // enable to start reading input values
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // get x or y values from the input actions
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Turn vehicle along Y (yaw motion)
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
