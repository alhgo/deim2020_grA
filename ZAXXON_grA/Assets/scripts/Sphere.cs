using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Método para mover la nave con el joystick
        MoverNave();
       
    }

    

    void MoverNave()
    {
       
        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        //restringir movimiento en el eje X y parte del codigo de Iris (SpaceWorld y rotación)
        if (posX < 14 && posX > -14 || posX < -14 && desplX > 0 || posX > 14 && desplX < 0)
        {
             transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }

        //restringir movimiento en el eje Y
        if (posY < 10 && posY > 1 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }
         
        //rotación nave
         transform.rotation = Quaternion.Euler(desplY * -10, 0 , desplX * -20);
         
    }


}

