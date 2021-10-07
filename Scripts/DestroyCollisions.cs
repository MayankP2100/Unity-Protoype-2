using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);        //Destroys the projectile (food)
        Destroy(other.gameObject);  //Destorys the gameobject hit by the projectile
    }
}
