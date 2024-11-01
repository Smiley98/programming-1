using UnityEngine;

public class Pong : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle1;
    public GameObject paddle2;

    void Update()
    {
        float dt = Time.deltaTime;
        float paddleSpeed = 5.0f;
        if (Input.GetKey(KeyCode.W))
        {
            paddle1.transform.position += Vector3.up * paddleSpeed * dt;
        }
        if (Input.GetKey(KeyCode.S))
        {
            paddle1.transform.position += Vector3.down * paddleSpeed * dt;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            paddle2.transform.position += Vector3.up * paddleSpeed * dt;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            paddle2.transform.position += Vector3.down * paddleSpeed * dt;
        }

        ball.transform.position += Vector3.right * 10.0f * dt;
    }
}
