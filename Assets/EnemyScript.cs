using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyScript : MonoBehaviour
{
    [SerializeField] public int enemyHealth = 100;
    [SerializeField] private int playerAttack = 10;

    private float enemyLimitHealth = 100;
    public int randomInteger;
    public int randomIntegerXp;

    
    private void Start()
    {
        Debug.Log("An enemy has appeared, attack to gain xp!");
        
    }
       void Update()
       {
        
            if (Input.GetKeyDown(KeyCode.A))
            {
                playerAttack = Random.Range(7, 15);

                if (playerAttack > 1)
                {
                    enemyHealth = enemyHealth - playerAttack;

                }


                if (enemyHealth < 100 && enemyHealth > 0)
                {
                    Debug.Log($"Enemy health at " + enemyHealth);
                }
                if (enemyHealth < 0)
                {
                    randomIntegerXp = Random.Range(15, 40);
                    Debug.Log("Enemy has been killed, you gained xp amount " + randomIntegerXp);
                    FindObjectOfType<PlayerCharacter>().UpdatePlayerXp(randomIntegerXp);
                  if (enemyHealth < 0)
                  {
                    enemyHealth = 100;
                  }
                    
                }

            }
        
       }
}
