using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{

    public float speed ;
    public float dificultad;
    public bool alive;
    public float vidas = 4;
    public float velocidadnaves;
    public GameObject UI;
    private UI ui;


    // Start is called before the first frame update
    void Start()
    {

        ui = UI.GetComponent<UI>();


        speed = 30;
        alive = true;
        velocidadnaves = 30;

        StartCoroutine("AumentoDificultad");





    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator AumentoDificultad()
    {
        for (int n = 0; ; n++)
        { 
            if (ui.puntuacion <= 100)
            {
                velocidadnaves= 20;
                dificultad = 1;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 200 && ui.puntuacion <= 400)
            {
                velocidadnaves = 25;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 400 && ui.puntuacion <= 600)
            {
                velocidadnaves = 30;
                dificultad = 2;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 600 && ui.puntuacion <= 700)
            {
                velocidadnaves = 35;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 700 && ui.puntuacion <= 800)
            {
                velocidadnaves = 40;
                dificultad = 3;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 800 && ui.puntuacion <= 900)
            {
                velocidadnaves = 45;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 900 && ui.puntuacion <= 1000)
            {
                velocidadnaves = 50;
                dificultad = 4;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 1000 && ui.puntuacion <= 1200)
            {
                velocidadnaves = 70;
                dificultad = 5;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 1200f)
            {
                velocidadnaves = 90;
                dificultad = 6;
                print("Tu velocidad es = " + velocidadnaves);
            }
            yield return new WaitForSeconds(0.1f);
        }
        
    }

   
   
}

