using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    public GameObject circle1;
    public GameObject circle2;

    void Start()
    {
        
    }

    void Update()
    {
        bool collision = CheckCollisionCircles(circle1.transform.position, circle2.transform.position, 0.5f, 0.5f);
        Color color = collision ? Color.red : Color.green;
        circle1.GetComponent<SpriteRenderer>().color = color;
        circle2.GetComponent<SpriteRenderer>().color = color;
    }

    bool CheckCollisionCircles(Vector2 position1, Vector2 position2, float radius1, float radius2)
    {
        // Overlap if the distance between centres is less than the sum of the radii!
        float radiiSum = radius1 + radius2;
        float distance = Vector2.Distance(position1, position2);
        return distance < radiiSum;
    }


}
