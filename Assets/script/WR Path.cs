using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5.0f;
    private int currentWaypoint = 0;

    private void Start()
    {
        
    }

    void Update()
    {
        if (currentWaypoint < waypoints.Length)
        {
            // Move towards the current waypoint
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);

            // Check if the object has reached the current waypoint
            if (transform.position == waypoints[currentWaypoint].position)
            {
                currentWaypoint++; // Move to the next waypoint
            }
        }
    }
}