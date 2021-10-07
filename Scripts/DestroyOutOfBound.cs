using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float topBound = 30.0f;
    public float lowerBound = -10.0f;
    // Update is called once per frame
    void Update()
    {
        // Destroying gameobjects
        if (transform.position.z > topBound | transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
        }
    }
}
