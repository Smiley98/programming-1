using UnityEngine;

public class Loops : MonoBehaviour
{
    public GameObject rect;

    void Start()
    {
        // This is called a "for-loop".
        // A loop runs a peace of code over and over
        // for-loops start with a counter (int i = 0 in this case)
        // Then they have a condition which determines whether we continue the loop
        // Lastly they increment the counter if the condition is met
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        // Instantiate creates a clone of the specified prefab
        Instantiate(rect);
        Instantiate(rect).transform.position = new Vector3(5.0f, 0.0f);
        Instantiate(rect).transform.position = new Vector3(-5.0f, 0.0f);
        Instantiate(rect).transform.position = new Vector3(0.0f, 5.0f);
        Instantiate(rect).transform.position = new Vector3(0.0f, -5.0f);
    }

    //void Update()
    //{
    //    
    //}
}
