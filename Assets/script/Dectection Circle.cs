using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    public float detectionRadius = 3f; // Radius of the detection circle

    public LayerMask layerToDetect;

    private void Update()
    {
        // Detect objects within the detection circle
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRadius, layerToDetect);

        foreach (Collider2D collider in colliders)
        {
            // Perform actions on detected objects (e.g., print their names)
            //Debug.Log("Detected: " + collider.gameObject.name);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a wire sphere in the Scene view to represent the detection circle
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}

