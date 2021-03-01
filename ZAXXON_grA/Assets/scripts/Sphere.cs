using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed = 10f;
    float speedMov = 10f;

    [SerializeField] Text SpeedText;

    [SerializeField] GameObject DistanceObject;
    private Distance distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = DistanceObject.GetComponent<Distance>();

        StartCoroutine("SpeedCorrutine");
    }

    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();


    }

    void SendtoConsole()
    {
        print("Estás moviendo la nave, accediendo a uno de sus métodos");
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
            transform.Translate(Vector3.right * Time.deltaTime * speedMov * desplX);
        }
       

        if (posY > 1 && posY < 8 || posY < 1 && desplY > 0 || posY > 8 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speedMov * desplY);
        }
        
    }
    void CheckSpeed()
    {
        float speedSimulated;

        if(distance.distancia <= 15)
        {
            speed = 1f;
            speedSimulated = 10f;
        }
        else if(distance.distancia <= 100)
        {
            speed = 5f;
            speedSimulated = 50f;
        }
        else if (distance.distancia <= 500)
        {
            speed = 10f;
            speedSimulated = 100f;
        }
        else if (distance.distancia <= 1000)
        {
            speed = 25f;
            speedSimulated = 250f;
        }
        else if (distance.distancia <= 2500)
        {
            speed = 50f;
            speedSimulated = 500f;
        }
        else
        {
            speed = 100f;
            speedSimulated = 1000f;
        }

        //SpeedText.text = speed.ToString();
        SpeedText.text = "Velocidad: " + speedSimulated + "km/h";
    }

    IEnumerator SpeedCorrutine()
    {
        int n;
        for (n = 0; ; n++)
        {
            CheckSpeed();
            yield return new WaitForSeconds(1);
        }

    }
}
