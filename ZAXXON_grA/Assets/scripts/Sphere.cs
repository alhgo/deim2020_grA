using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed = 2.5f;

    [SerializeField] Text SpeedText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();

        //SpeedText.text = speed.ToString();
        SpeedText.text = "Velocidad: " + speed + "km/h";
    }

    void SendtoConsole()
    {
        print("Estás accediendo a un método de la esfera");
    }

    void MoverNave()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;

       //print(posY);

        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        if(posX > -15 && posX < 15 || posX < -15 && desplX > 0 || posX > 15 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
       

        if (posY > 1 && posY < 8 || posY < 1 && desplY > 0 || posY > 8 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        

    }
}
