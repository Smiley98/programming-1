using UnityEngine;


// 1. Variables(int, float, Vector2, Vector3)
// 2. Operations(+-*/)
// 3. Decisions(if/else)
public class Review : MonoBehaviour
{
    void Start()
    {
        //int wholeNumber = 100;
        //float decimalNumber = 69.42f;
        //Debug.Log("My whole number is " + wholeNumber);
        //Debug.Log("My decimal number is " + decimalNumber);

        // 1. Variables
        int a = 7;
        int b = 2;
        float c = 7.0f;
        float d = 2.0f;
        
        // 2. Math operations
        // Note that int can only be whole numbers so even though A / B = 3.5, we always round down (to 3 in this case)
        Debug.Log("A + B = " + (a + b));
        Debug.Log("A - B = " + (a - b));
        Debug.Log("A * B = " + (a * b));
        Debug.Log("A / B = " + (a / b));

        // Decimal math works as expected with floats!
        Debug.Log("C + D = " + (c + d));
        Debug.Log("C - D = " + (c - d));
        Debug.Log("C * D = " + (c * d));
        Debug.Log("C / D = " + (c / d));

        // 3. Conditions
        if (1 > 2)
        {
            Debug.Log("Condition was true");
        }
        else
        {
            Debug.Log("Condition was false");
        }

        // else-if only runs if the previous case was false
        int number = 1;
        if (number == 1)
        {
            Debug.Log("Number is 1");
        }
        else if (number == 2)
        {
            Debug.Log("Number is 2");
        }
        else if (number == 3)
        {
            Debug.Log("Number is 3");
        }
        else
        {
            Debug.Log("I can't count that high!");
        }
    }

    // Player movement via WASD!
    void Update()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
        }

        float dt = Time.deltaTime;
        float speed = 10.0f;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;
    }
}
