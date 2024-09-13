using UnityEngine;

public class CoolScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int health = 100;
        int defense = 10;
        int attack = 50;
        int speed = 5;
        int regeneration = 15;
        int damage = attack * speed / defense;

        Debug.Log("Initial Stats:");
        Debug.Log("Attack: " + attack);
        Debug.Log("Defense: " + defense);
        Debug.Log("Speed: " + speed);
        Debug.Log("Damage: " + damage);
        Debug.Log("Regeneration: " + regeneration);

        Debug.Log("Applying " + damage + " damage.");
        health = health - damage;
        Debug.Log("Health is now " + health);

        Debug.Log("Applying " + regeneration + " regeneration.");
        health = health + regeneration;
        Debug.Log("Health is now " + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
