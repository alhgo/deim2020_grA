using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{

    public float speed ;
    public float dificultad;
    public bool alive;
    public float vidas = 3;
    public GameObject columnagame;
    public Columna columna;


    // Start is called before the first frame update
    void Start()
    {
        speed = 30;
        dificultad = 10;
        alive = true;
       columnagame = GameObject.Find("CocheEnemigo");
       columna = columnagame.GetComponent<Columna>();
       columna.velocidadcolumnas = 30;

        

    }

    // Update is called once per frame
    void Update()
    {
        AumentoDificultad();
        print(alive);
      
    }


    void AumentoDificultad()
    {


    }

   
   
}

