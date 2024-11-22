using UnityEngine;

public class Functions : MonoBehaviour
{
    // "int" = data-type, "example" = variable's name
    int example = 5;

    // "void" = no output, "Start" = function's name
    void Start()
    {
        int number1 = 5;
        int number2 = 6;
        int sum = Add(number1, number2);
        int difference = Sub(number1, number2);
        Debug.Log(sum);
        Debug.Log(difference);

        float[] numbers = { 4.4f, 7.7f, 2.2f, 3.3f, 6.6f, 9.9f, 8.8f };
        float largestNumber = FindHighest(numbers);
        Debug.Log(largestNumber);

        // 1. Create a Mul function that multiplies 2 double-precision numbers
        // 2. Create a Div function that divides 2 double-precision numbers
        // 3. Create a FindLowest function that finds the lowest number within an array
    }

    // "int" = output, "Add" = name, "a and b" = inputs 1 & 2
    int Add(int a, int b)
    {
        // Output the result of a + b ("return" = output)
        return a + b;
    }

    // "int" = output, "Sub" = name, "a and b" = inputs 1 & 2
    int Sub(int a, int b)
    {
        // Output the result of a - b ("return" = output)
        return a - b;
    }

    // "float" = output, "FindHighest" = name, "numbers" = input
    float FindHighest(float[] numbers)
    {
        float highest = float.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > highest)
            {
                highest = numbers[i];
            }
        }
        return highest;
    }
}
