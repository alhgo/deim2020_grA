﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spaceship : MonoBehaviour
{
    public float speed;
    [SerializeField] Text Speed;
    [SerializeField] Text TimePlayed;
    [SerializeField] Text Distance;
    //public GameObject[] ObjetoEnemigo;
    [SerializeField] Collider naveCollider;
    [SerializeField] MeshRenderer naveMesh;
    //private Enemigo enemigo;
    float tiempo;
    float minutos;
    float segundos;
    //string distancia;

    
    // Start is called before the first frame update
    void Start()
    {
        speed = 12.5f;
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
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }

        //restringir movimiento en el eje Y
        if (posY < 10 && posY > 1 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }

        transform.rotation = Quaternion.Euler(desplY * -20, 0, desplX * -20);
    }

    void UIMarcadores(){ 
        tiempo += Time.deltaTime;
        segundos = (int) tiempo % 60;
        minutos = (int) ((tiempo / 60) % 60);

        //distancia = enemigo.mySpeed.ToString();
        
        //Speed.text = "VELOCIDAD: " + enemigo.mySpeed * 100 + " km/min";        
        TimePlayed.text = "TIEMPO JUGANDO: " + minutos.ToString("00") +":" + segundos.ToString("00");
        //Distance.text = "DISTANCIA RECORRIDA: " + distancia;
        
    }

    void OnTriggerEnter (Collider enemigo)
    {
        if(enemigo.gameObject.tag == "Obstaculo")
        {
            print("chocaste");
        }
    }
}
