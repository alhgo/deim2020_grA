using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    public GameObject Nave;
    private Sphere sphere;

    private Vector3 MyPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;
//publica porque lo usaremos en otros scripts
   public float mySpeed;
    



    
    // Start is called before the first frame update
    void Start()
    {
        Nave = GameObject.Find("Sphere");

        sphere = Nave.GetComponent<Sphere>();
        mySpeed = sphere.speed;
      
      
       //la velocidad que le hemos asignado a las columnas
        mySpeed = 5f;
       //aqui estoy comprobando la velocidad en la consola 
        print(mySpeed);
    }

    // Update is called once per frame
    void Update()
    {
       
        MyPos = transform.position;
         FinalPos = MyPos + DestPos * Time.deltaTime * mySpeed;
            transform.position = FinalPos;
        print(MyPos);
       
       
    }
    //Creamos un void para el movimiento de las columnas y su destruccion
        void MovimientoColumna(){
        
           //Ese transform coge la posicion del objeto lo mueve hacia atras para cambiar la direccion cambia el .back / .up .down .forward .left .right 
           //para cambiar la velocidad a la que se mueven estas columnas cambio el mySpeed
            transform.Translate(Vector3.back * Time.deltaTime * mySpeed);
       
           //este if coge la posicion de tu objeto asignado y si sobrepasa la posicion lo destruye
            if(transform.position.y > 25)
            {
                //destroy es un metodo de unity y si pones gameobject porque lo  que buscas es destruir el objeto entero
                Destroy(gameObject);
            }




        }
}
