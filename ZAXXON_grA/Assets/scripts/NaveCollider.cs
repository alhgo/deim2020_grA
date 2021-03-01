using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveCollider : MonoBehaviour
{
    [SerializeField] MeshRenderer myMesh;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            print("Se ha chocado con un obstáculo");
            myMesh.enabled = false;
        }
    }

    /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            print("Se ha chocado con un obstáculo");
            //Destroy(gameObject);

            myMesh.enabled = false;
        }
        
    }*/
}
