using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();

    }

    void MoverNave()
    {
        //print(transform.position.x);
         float posX = transform.position.x;         
         float posY = transform.position.y;       
         float desplY = Input.GetAxis("Vertical"); 
         float desplX = Input.GetAxis("Horizontal");          
        //restringir movimiento en el eje X        
         if (posX < 15 && posX > -15  || posX < -15 && desplX > 0 || posX > 15 && desplX < 0)        
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
            

        }
        //restringir movimiento en el eje Y        
        if (posY < 10 && posY > 1 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)        
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
            
        }

        //rotacion nave
        transform.rotation = Quaternion.Euler(0, 0, desplX * -20);






    }

 }

