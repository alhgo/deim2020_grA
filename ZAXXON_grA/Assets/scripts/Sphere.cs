﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed;
    [SerializeField] Text Speed;
    [SerializeField] Text TimePlayed;
    [SerializeField] Text Distance;
    [SerializeField] Text Prueba;
    public GameObject ObjetoColumna;
    private Columna columna;
    float tiempo;
    float minutos;
    float segundos;
    string distancia;

    
    // Start is called before the first frame update
    void Start()
    {

        columna = ObjetoColumna.GetComponent<Columna>();
        speed = 10;
        tiempo = 0;
        minutos = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();
        //Método UI tiempo y velocidad
        UIMarcadores();

    }

    void MoverNave()
    {
        //print(transform.position.x);
        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        //restringir movimiento en el eje X
        if (posX < 14 && posX > -14 || posX < -14 && desplX > 0 || posX > 14 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //restringir movimiento en el eje Y
        if (posY < 10 && posY > 1 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
    }

    void UIMarcadores(){ 
        tiempo += Time.deltaTime;
        segundos = (int) tiempo % 60;
        minutos = (int) ((tiempo / 60) % 60);

        distancia = columna.mySpeed.ToString();
        
        Speed.text = "VELOCIDAD: " + columna.mySpeed * 100 + " km/min";        
        TimePlayed.text = "TIEMPO JUGANDO: " + minutos.ToString("00") +":" + segundos.ToString("00");
        Distance.text = "DISTANCIA RECORRIDA: " + distancia;
        
    }

    

}
