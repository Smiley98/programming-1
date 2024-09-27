using UnityEngine;

public class BattleTest : MonoBehaviour
{
    // See homework 3 document for Week 4 homework!
    void Start()
    {
        Debug.Log("Prepare for battle!");

        int playerHealth = 100;
        int enemyHealth = 50;

        if (playerHealth > enemyHealth)
        {
            // If the player has more health than the enemy, the "true" case runs
            Debug.Log("Begone foul fiend!!!");
        }
        else
        {
            // Otherwise, if the enemy has more health than the player, the "false" case runs
            Debug.Log("Begone pathetic player ;p ;p");
        }
    }
}
