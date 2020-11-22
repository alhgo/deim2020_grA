using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    public GameObject Nave;
    private Sphere sphere;

    private Vector3 MyPos;


    //Variable velocidad
    public float mySpeed;

    // Start is called before the first frame update
    void Start()
    {
      
        mySpeed = 10f;
        
    }

    // Update is called once per frame
    void Update()
    { 

      transform.Translate(Vector3.back * Time.deltaTime * mySpeed);

        if(transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
