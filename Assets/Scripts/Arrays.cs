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
    }
}
