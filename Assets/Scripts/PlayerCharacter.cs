using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first
    [SerializeField] private int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;

    // Methods will go underneath here

    // Start is called before the first frame update
   private void Start()
    {
        attack =  10;
        health = 100;
        level =    1;
    }
    
    // add a level
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        Debug.Log("Your name is gabe and you've started this journey in this dungeon, kill enemys and climb to level 5 to win. An enemy appears infront of you, attack it!");
    }
    
    
}
