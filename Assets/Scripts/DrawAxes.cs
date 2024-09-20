using UnityEngine;

public class DrawAxes : MonoBehaviour
{
    void Update()
    {
        // Store the right-vector (x-axis
        Vector3 x = Vector3.right;

        // Store the up-vector (y-axis)
        Vector3 y = Vector3.up;

        // Store the forward-vector (z-axis)
        Vector3 z = Vector3.forward;

        // Start and end points along the x-axis
        Vector3 x1 = transform.position;
        Vector3 x2 = x1 + x * 5.0f;

        // Start and end points along the y-axis
        Vector3 y1 = transform.position;
        Vector3 y2 = y1 + y * 5.0f;

        // Start and end points along the z-axis
        Vector3 z1 = transform.position;
        Vector3 z2 = z1 + z * 5.0f;

        // Draw line from x1 to x2 (red line for x-axis)
        Debug.DrawLine(x1, x2, Color.red);

        // Draw line from y1 to y2 (green line for y-axis)
        Debug.DrawLine(y1, y2, Color.green);
        
        // Draw line from z1 to z2 (blue line for z-axis)
        Debug.DrawLine(z1, z2, Color.blue);

    // Move an object by computing a time-based position change:
        // Store the time from previous frame to current frame
        float dt = Time.deltaTime;

        // Set a speed to move -- 2 units per second!
        float speed = 2.0f;

        // Set a velocity to move -- direction times speed times time
        Vector3 velocity = x * speed * dt;

        // Apply the velocity to position, resulting in smooth movement!!!
        transform.position = transform.position + velocity;
    }
}
