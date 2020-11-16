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
        float posX = transform.position.x;
        float posY = transform.position.y;

        print(posY);

        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        if(posX > -10 && posX < 10 || posX < -10 && desplX > 0 || posX > 10 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
       

        if (posY > 1 && posY < 10 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        

    }
}
