using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 2.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();

    }

    void MoverNave()
    {
        print(transform.position.x);

        float desplY = Input.GetAxis("Vertical");
       
        float desplX = Input.GetAxis("Horizontal");

        float PosX = transform.position.x;
        float PosY = transform.position.y;

        //Eje X

        if (PosX > -9.5 && PosX < 9.5)
        {       
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //Método de permitir movimiento contrario para corregir error en eje X

        else if (PosX < -9.5 && desplX > 0)
        {
            transform.Translate(Vector3.right*Time.deltaTime*speed*desplX);
        }
        else if (PosX > 9.5 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //Eje Y

        if (PosY > 1.5 && PosY < 6.5)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }

        //Método de permitir movimiento contrario para corregir error en eje Y

        else if (PosY < 1.5 && desplY > 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        else if (PosY > 3.5 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
    }
}
