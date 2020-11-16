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

        MoverNave();
       
    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        print(transform.position.x);
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");
        //Restringir mov horizontal
        if(PosX >0 && PosX<30)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
       else if(PosX<0 && desplX>0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        else if (PosX > 30 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        //Restringir mov vertical
        if (PosY > 1 && PosY < 9)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        else if (PosY < 1 && desplY > 0 )
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        else if (PosY > 9 && desplY < 1)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }

    }
}
