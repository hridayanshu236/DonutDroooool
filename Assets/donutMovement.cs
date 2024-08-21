using UnityEngine;

public class donutMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = -2000f;
    public float sidewaysForce = 500f;
    public float torqueForce = 1000f; // New variable for torque

    void Start()
    {
        // Automatically assign the Rigidbody component at the start
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() // Because we are using it to mess with physics
    {
        // Adds forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Apply force to move the donut forward/backward
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime); // Move forward
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime); // Move backward
        }

        // Apply torque to rotate the donut left/right
        if (Input.GetKey("a"))
        {
            rb.AddTorque(Vector3.up * torqueForce * Time.deltaTime); // Rotate left
        }
        if (Input.GetKey("d"))
        {
            rb.AddTorque(-Vector3.up * torqueForce * Time.deltaTime); // Rotate right
        }
    }
}

