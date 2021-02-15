using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //public GameObject Nave;
    //public Sphere sphere;

    //private Vector3 MyPos;
    [SerializeField] Vector3 DestPos;
    //private Vector3 FinalPos;

    public float mySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        //Le asigno una velocidad inicial a la velocidad de las columnas
        mySpeed = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoEnemigo();        
    }

    void MovimientoEnemigo(){
        transform.Translate(Vector3.forward * Time.deltaTime * mySpeed);

        //Destruye las columnas por detrás del campo de visión
        if(transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }

}
