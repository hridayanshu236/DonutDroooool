using UnityEngine;

public class DonutMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float initialForce = 100f;
    public float movementForce = 500f;  // Moderate force for smoother rolling
    public float torqueForce = 200f;     // Adjusted torque for better control

    void Start()
    {
        // Automatically assign the Rigidbody component at the start
        rb = GetComponent<Rigidbody>();

        // Ensure the Rigidbody can rotate on all axes
        rb.constraints = RigidbodyConstraints.None;

        // Adjust Rigidbody settings for realistic physics
        rb.mass = 2f;  // Keep mass moderate
        rb.drag = 1f;  // Low drag for rolling
        rb.angularDrag = 1.2f;  // Low angular drag for smooth rotation
    }

    void FixedUpdate()
    {
        // Continuous forward force to maintain rolling along the global Z-axis
        rb.AddForce(Vector3.back * initialForce * Time.deltaTime);

        // Apply additional force to move forward/backward based on input along the global Z-axis
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.back * movementForce * Time.deltaTime); // Move forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.forward * movementForce * Time.deltaTime); // Move backward
        }

        // Apply torque to rotate the donut left/right around the global Y-axis
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(Vector3.up * -torqueForce * Time.deltaTime); // Rotate left
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * torqueForce * Time.deltaTime); // Rotate right
        }
    }
}
