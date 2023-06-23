using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first
    [SerializeField] public int level = 1;
    [SerializeField] public int xp = 0;
    private float xpLimit = 100;
    private bool runOnce;
    // Methods will go underneath here
    
    

        // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Your name is gabe and you've started this journey in this dungeon, kill enemys and climb to level 5 to win.Press A to start and attack later on");
        level = 1;
     }

        // add a level
        public void UpdatePlayerXp(int killed)
        {
            xp += killed;
            {
                if (xp >= xpLimit)
                {
                    Debug.Log("You have reached level " + level);
                    level = level + 1;
                    if (xp > 101)
                    {
                        xp = 0;
                    }
                    if (level >= 6)
                    {
                    Debug.Log("You have reached level 5 and are strong enough to leave the dungeon, congratulations");
                    }
                
                }
            }
        }
}
 