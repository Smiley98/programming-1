using UnityEngine;

public class Homework7 : MonoBehaviour
{
    // 1. Determine highest number
    // 2. Determine the lowest number
    // 3. Determine the index of the highest number
    // 4. Determine the index of the lowest number
    void Start()
    {
        float[] numbers = { 4.4f, 7.7f, 2.2f, 3.3f, 6.6f, 9.9f, 8.8f };

        float highest = float.MinValue;
        float lowest = float.MaxValue;
        int highestIndex = -1;
        int lowestIndex = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            float value = numbers[i];
            if (value > highest)
            {
                highest = value;
                highestIndex = i;
            }
            else if (value < lowest)
            {
                lowest = value;
                lowestIndex = i;
            }
        }

        Debug.Log("Highest number: " + highest);
        Debug.Log("Lowest number: " + lowest);
        Debug.Log("Highest number index: " + highestIndex);
        Debug.Log("Lowest number index: " + lowestIndex);
    }
}
