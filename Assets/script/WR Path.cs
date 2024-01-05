using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    public Transform[] waypoints; // Array to store waypoints
    public float speed = 2.0f; // Speed of movement
    private int currentWaypoint = 0; // Current waypoint index

    private void Update()
    {
        if (currentWaypoint < waypoints.Length)
        {
            // Move the object towards the current waypoint
            transform.position = Vector3.Lerp(
                transform.position,
                waypoints[currentWaypoint].position,
                speed * Time.deltaTime
            );

            // Check if the object is close enough to the current waypoint
            if (Vector3.Distance(transform.position, waypoints[currentWaypoint].position) < 0.1f)
            {
                // Move to the next waypoint
                currentWaypoint++;
            }
        }
        else
        {
            // When reached the end of the path, reset to the beginning
            
        }
    }
}
