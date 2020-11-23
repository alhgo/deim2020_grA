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
     float mySpeed;
    float myNewSpeed;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("CorrutinaDificultad");
        
        
    }

    // Update is called once per frame
    void Update()
    { 
    
    

     
      transform.Translate(Vector3.back * Time.deltaTime * myNewSpeed);

        if(transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
    

IEnumerator CorrutinaDificultad()
{
    
    for (int i=0; ;i++)
        {
            print(i);
           print(myNewSpeed + " es tu velocidad");
            print("Funciono");
    yield return new WaitForSeconds(10);  
        }
    
}

}
