using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrower : MonoBehaviour
{
    public GameObject objectToThrow;
    public GameObject targetObject;
    public KeyCode throwKey = KeyCode.Space;
    public float throwSpeed = 10f;

    private bool hasThrown = false;

    void Update()
    {
        if (Input.GetKeyDown(throwKey) && !hasThrown)
        {
            ThrowObject();
        }
    }

    void ThrowObject()
    {
        if (objectToThrow != null && targetObject != null)
        {
            GameObject thrownObject = Instantiate(objectToThrow, transform.position, transform.rotation);
            Rigidbody rb = thrownObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                Vector3 throwDirection = (targetObject.transform.position - transform.position).normalized;
                rb.velocity = throwDirection * throwSpeed;
            }

            hasThrown = true;
        }
    }
}
