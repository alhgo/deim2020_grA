using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveCollider : MonoBehaviour
{
    [SerializeField] MeshRenderer myMesh;

   /* [SerializeField] GameObject  ColumnaObject;
    Columna columna;*/

    [SerializeField] GameObject SphereObject;
    private Sphere sphere;

    [SerializeField] GameObject DistanceObject;
    private Distance distance;

    private void Start()
    {
        distance = DistanceObject.GetComponent<Distance>();
        sphere = SphereObject.GetComponent<Sphere>();
        /*columna = ColumnaObject.GetComponent<Columna>();*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            print("Se ha chocado con un obstáculo");
            myMesh.enabled = false;
            distance.crash = true;

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
