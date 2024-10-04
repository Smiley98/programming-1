using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 direction = Vector2.right;
    float speed = 10.0f;

    void Start()
    {
        // Uncomment to launch the ball at an angle
        //float angle = 30.0f * Mathf.Deg2Rad;
        //direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
    }

    void Update()
    {
        // If the ball is too far right, make it go left (1%, free)
        if (transform.position.x > 10.0f)
        {
            direction = -direction;
        }

        // If the ball is too far left, make it go right (1%)

        // If the ball is too far up, make it go down (1%)

        // If the ball is too far down, make it go up (1%)

        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;
    }
}
