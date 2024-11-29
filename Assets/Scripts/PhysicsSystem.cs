using UnityEngine;

public class PhysicsSystem : MonoBehaviour
{
    public GameObject prefab;
    PhysicsObject[] physicsObjects = new PhysicsObject[11];

    void Start()
    {
        for (int i = 0; i < physicsObjects.Length; i++)
        {
            PhysicsObject obj = Instantiate(prefab).GetComponent<PhysicsObject>();
            obj.transform.position = new Vector3(-10.0f + i * 2.0f, 0.0f);
        }
    }

    void Update()
    {
        
    }
}
