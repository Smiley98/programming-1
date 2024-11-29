using UnityEngine;

public class PhysicsSystem : MonoBehaviour
{
    public GameObject prefab;
    PhysicsObject[] physicsObjects = new PhysicsObject[11];

    // Homework 9:
    // 1. Modify the code to shoot all objects in random directions - 2%
    // 2. Make objects bounce off left-right-top-bottom edges of the screen - 2%
    void Start()
    {
        for (int i = 0; i < physicsObjects.Length; i++)
        {
            // Can access obj.vel and obj.acc
            PhysicsObject obj = Instantiate(prefab).GetComponent<PhysicsObject>();
            obj.transform.position = new Vector2(-10.0f + i * 2.0f, -5.0f);
        }
    }

    void Update()
    {
        
    }
}
