using UnityEngine;

public class Functions : MonoBehaviour
{
    void Start()
    {
        int number1 = 5;
        int number2 = 6;
        int sum = Add(number1, number2);
        int difference = Sub(number1, number2);
        Debug.Log(sum);
        Debug.Log(difference);

        float[] numbers = { 4.4f, 7.7f, 2.2f, 3.3f, 6.6f, 9.9f, 8.8f };
        float highest = FindHighest(numbers);
        Debug.Log(highest);

        // 1. Make a function called Mul that multiplies 2 double-precision numbers
        // 2. Make a function called Div that divides 2 double-precision numbers
        // 3. Make a function called FindLowest that finds the lowest number in an array
    }

    // "int" = output, "Add" = name, "int a and int b" = two integer inputs
    int Add(int a, int b)
    {
        return a + b;
    }

    // "int" = output, "Sub" = name, "int a and int b" = two integer inputs
    int Sub(int a, int b)
    {
        return a - b;
    }

    float FindHighest(float[] numbers)
    {
        float highest = float.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > highest)
                highest = numbers[i];
        }
        return highest;
    }
}
