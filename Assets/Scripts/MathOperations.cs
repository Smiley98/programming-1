using UnityEngine;

public class MathOperations : MonoBehaviour
{
    void Start()
    {
        //int number = 420;
        //Debug.Log(number);      // Logs 420
        //Debug.Log("number");    // Logs number

        int health = 100;
        int defense = 10;
        int attack = 50;
        int speed = 5;
        int regeneration = 15;
        int damage = attack * speed / defense;

        Debug.Log("---Logging Combat Stats---");
        Debug.Log("Health: " + health);
        Debug.Log("Defense: " + defense);
        Debug.Log("Attack: " + attack);
        Debug.Log("Speed: " + speed);
        Debug.Log("Damage: " + damage);
        Debug.Log("Regeneration: " + regeneration);

        Debug.Log("Applying damge of " + damage + " to health of " + health);
        health = health - damage;
        Debug.Log("Health is now " + health);

        Debug.Log("Applying regeneration of " + regeneration + " to health of " + health);
        health = health + regeneration;
        Debug.Log("Health is now " + health);
    }
}
