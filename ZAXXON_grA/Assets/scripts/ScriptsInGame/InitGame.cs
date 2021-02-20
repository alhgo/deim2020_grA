using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{

    public float speed ;
    
    public bool alive;
    public float vidas = 4;
    public float velocidadnaves;
    public GameObject UI;
    private UI ui;


    // Start is called before the first frame update
    void Start()
    {

        ui = UI.GetComponent<UI>();


        speed = 45;
        alive = true;

        StartCoroutine("AumentoDificultad");





    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Corrutina para el aumento de velocidad.
    IEnumerator AumentoDificultad()
    {
        for (int n = 0; ; n++)
        { 
            if (ui.puntuacion <= 100)
            {
                velocidadnaves= 30;
                
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 200 && ui.puntuacion <= 400)
            {
                velocidadnaves = 35;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 400 && ui.puntuacion <= 600)
            {
                velocidadnaves = 45;
                
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 600 && ui.puntuacion <= 700)
            {
                velocidadnaves = 55;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 700 && ui.puntuacion <= 800)
            {
                velocidadnaves = 70;
               
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 800 && ui.puntuacion <= 900)
            {
                velocidadnaves = 85;
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 900 && ui.puntuacion <= 1000)
            {
                velocidadnaves = 95;
               
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 1000 && ui.puntuacion <= 1200)
            {
                velocidadnaves = 115;
                
                print("Tu velocidad es = " + velocidadnaves);
            }
            else if (ui.puntuacion >= 1200f)
            {
                velocidadnaves = 130;
                
                print("Tu velocidad es = " + velocidadnaves);
            }
            yield return new WaitForSeconds(0.1f);
        }
        
    }

   
   
}

