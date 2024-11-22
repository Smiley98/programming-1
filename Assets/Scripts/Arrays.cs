using UnityEngine;

public class Arrays : MonoBehaviour
{
    void Start()
    {
        // Old way of doing things
        //int enemyHealth1 = 100;
        //int enemyHealth2 = 50;
        //int enemyHealth3 = 75;
        //int enemyHealth4 = 200;
        //int enemyHealth5 = 9001;
        //
        //Debug.Log(enemyHealth1);
        //Debug.Log(enemyHealth2);
        //Debug.Log(enemyHealth3);
        //Debug.Log(enemyHealth4);
        //Debug.Log(enemyHealth5);

        Debug.Log("Initial health values:");
        int[] enemyHealths = { 100, 50, 75, 200, 9001 };
        for (int i = 0; i < enemyHealths.Length; i++)
        {
            int health = enemyHealths[i];
            Debug.Log(health);
        }
        
        Debug.Log("Modified health values:");
        enemyHealths[0] = 420;
        enemyHealths[1] = 69;
        enemyHealths[2] = 1337;
        enemyHealths[3] = 42;
        enemyHealths[4] = 42069;
        //enemyHealths[5] = 666; *ERROR* --> cannot access an element outside of the array!
        for (int i = 0; i < enemyHealths.Length; i++)
        {
            Debug.Log(enemyHealths[i]);
        }

        // 1. Determine highest number
        // 2. Determine the lowest number
        // 3. Determine the index of the highest number
        // 4. Determine the index of the lowest number
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
