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
        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;
    }
}
