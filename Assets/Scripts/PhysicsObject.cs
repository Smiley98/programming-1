using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    Vector2 acc = Physics.gravity;
    Vector2 vel = Vector2.up * 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        // velocity = acceleration * time
        // position = velocity * time
        float dt = Time.deltaTime;
        vel += acc * dt;
        Vector3 change = vel * dt;
        transform.position += change;

        // Improvement: store initial position and initial velocity
        // (So you're not hard-coding position <= -5 and vel = [0, 10])
        if (transform.position.y <= -5.0f)
        {
            vel = new Vector2 (0.0f, 10.0f);
        }
    }
}
