using UnityEngine;

public class DrawAxes : MonoBehaviour
{
    void Update()
    {
        Vector3 xDirection = Vector3.right;
        Vector3 x1 = transform.position;
        Vector3 x2 = transform.position + xDirection * 5.0f;

        Vector3 yDirection = Vector3.up;
        Vector3 y1 = transform.position;
        Vector3 y2 = transform.position + yDirection * 5.0f;

        Vector3 zDirection = Vector3.forward;
        Vector3 z1 = transform.position;
        Vector3 z2 = transform.position + zDirection * 5.0f;

        Debug.DrawLine(x1, x2, Color.red);
        Debug.DrawLine(y1, y2, Color.green);
        Debug.DrawLine(z1, z2, Color.blue);

        float dt = Time.deltaTime;
        float speed = 2.0f;
        Vector3 velocity = xDirection * speed * dt;
        transform.position = transform.position + velocity;
    }
}
