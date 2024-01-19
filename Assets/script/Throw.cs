using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrower : MonoBehaviour
{
    public GameObject objectToThrow;
    public GameObject[] targetObject;
    public KeyCode[] throwKeys;
    public float throwSpeed = 10f;

    private bool hasThrown = false;

    void Update()
    {
        if (Input.GetKeyDown(throwKeys[0]) && !hasThrown)
        {
            ThrowObject(0);
        }
        else if (Input.GetKeyDown(throwKeys[1]) && !hasThrown)
        {
            ThrowObject(1);
        }
        else if (Input.GetKeyDown(throwKeys[2]) && !hasThrown)
        {
            ThrowObject(2);
        }
        else if(Input.GetKeyDown(throwKeys[3]) && !hasThrown)
        {
            ThrowObject(3);
        }
        else if (Input.GetKeyDown(throwKeys[4]) && !hasThrown)
        {
            ThrowObject(4);
        }
    }

    void ThrowObject(int teamate)
    {
        if (objectToThrow != null && targetObject != null)
        {
            GameObject thrownObject = Instantiate(objectToThrow, transform.position, transform.rotation);
            Rigidbody rb = thrownObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                Vector3 throwDirection = (targetObject[teamate].transform.position - transform.position).normalized;
                rb.velocity = throwDirection * throwSpeed;
            }

            hasThrown = true;
        }
    }
}
