using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // The target object to follow (e.g., player)
    public float moveSpeed = 3f; // Speed at which the enemy follows

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (target != null)
        {
            // Get the direction towards the target
            Vector2 direction = (target.position - transform.position).normalized;

            // Move the enemy towards the target
            rb.velocity = direction * moveSpeed;
        }
    }
}