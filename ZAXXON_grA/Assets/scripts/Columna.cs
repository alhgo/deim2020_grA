using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
   
    private Vector3 MyPos;
    public float mySpeed;
    public float myNewSpeed;

    // Start is called before the first frame update
    void Start()
    {
      
        
        
    }

    // Update is called once per frame
    void Update()
    { 


AumentoVelocidad();
        transform.Translate(Vector3.back * Time.deltaTime * myNewSpeed);
        if(transform.position.z < -10)
        {
            Destroy(gameObject);

        }
    }
    
    public void AumentoVelocidad(){

        mySpeed = myNewSpeed;
    }
   
    
}


