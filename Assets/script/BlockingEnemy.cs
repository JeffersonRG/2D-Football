using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lineman : MonoBehaviour
{
    // Speed to apply to the enemy when it enters the collider
    public float reducedSpeed = 0.5f; // Set your desired reduced speed here

    // This method is called when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered is tagged as an enemy
        if (other.CompareTag("Enemy"))
        {
            // Get the EnemyMovement script or component from the enemy GameObject
            FollowPlayer EnemyMovement = other.GetComponent<FollowPlayer>();

            // Check if the EnemyMovement script/component is found
            //if (FollowPlayer != null)
            {
                // Set the enemy's movement speed to the reduced speed
                //enemyMovement.SetSpeed(reducedSpeed);
            }
        }
    }
}

