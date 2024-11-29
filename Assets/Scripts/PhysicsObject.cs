using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    public Vector2 acc = Physics.gravity;
    public Vector2 vel = Vector2.up * 10.0f;
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
            transform.position = new Vector3(transform.position.x, -5.0f);
            vel = new Vector2(0.0f, 10.0f);
        }
    }
}
