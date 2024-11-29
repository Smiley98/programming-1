using UnityEngine;

public class MouseAngle : MonoBehaviour
{
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        mouse.z = 0.0f;

        Vector3 direction = (mouse - transform.position).normalized;
        //float angle = Vector3.Angle(Vector3.right, direction);
        float angle = Vector3.SignedAngle(Vector3.right, direction, Vector3.forward);

        Debug.DrawLine(transform.position, mouse, Color.red);
        Debug.Log(angle);
    }
}
