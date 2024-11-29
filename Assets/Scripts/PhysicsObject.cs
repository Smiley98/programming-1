using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    Vector2 acc = Physics.gravity;
    Vector2 vel = Vector2.zero;//Vector2.up * 10.0f;

    void Update()
    {
        float dt = Time.deltaTime;
        vel += acc * dt;
        Vector3 change = vel * dt;
        transform.position += change;

        if (transform.position.y <= -5.0f)
        {
            vel = Vector2.up * 10.0f;
        }
    }
}
