using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingEnemy : MonoBehaviour
{
    // Speed reduction factor for the enemy
    public float speedReductionFactor = 0.5f; // Adjust this value as needed

    // This method is called when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered is tagged as an enemy
        if (other.CompareTag("Enemy"))
        {
            // Get the EnemyMovement script or component from the enemy GameObject
            EnemyMovement enemyMovement = other.GetComponent<EnemyMovement>();

            // Check if the EnemyMovement script/component is found
           // if (enemyMovement != null)
            {
                // Reduce the enemy's movement speed
               // enemyMovement.ReduceSpeed(speedReductionFactor);
            }
        }
    }
}
