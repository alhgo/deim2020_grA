using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    //declaro el variable de velocidad de mov. y su posicion inicial como un vector de 3 dimensiones.
    public float speed = 30f;
    private Vector3 StartPosition;

    //Indico que la posición inicial es la misma que a la que se tiene que teletransportar..
       void Start()
    {
        StartPosition = transform.position;
    }

    //le digo que se traslade hacia atrás para dar sensacion de mov. y si la posicion en z es menos que X que teletransporte a la posicion inicial para bucle infinito.
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z < -64.03f)
        {
            transform.position = StartPosition;
        }
    }
    
}
