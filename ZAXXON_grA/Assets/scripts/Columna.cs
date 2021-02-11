using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Columna : MonoBehaviour
{
    public GameObject Nave;
    private Sphere sphere;

    private Vector3 MyPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;

    
    float mySpeed;
    
    // Start is called before the first frame update
    void Start()
    {

        /*Difficulty();*/

       
        mySpeed = 50f;
      
    }

    void Update()
    {
     //movimiento de las colunas y su destrucción

       transform.Translate(Vector3.back * Time.deltaTime * mySpeed);
        //print(MyPos);

        if(transform.position.z < -20)
        {
            Destroy(gameObject);
        }
    }

     //dificultad incremental del juego (por corregir)
    /*void Difficulty()
    {

     for (int n = 0; ; n++)
        {
            if (ui.puntuacion <= 100)
            {
                mySpeed = 10f;
                print("Tu velocidad es =" + mySpeed);

            }

            else if (ui.puntuacion >= 100 && ui.puntuacion <= 300)
            {
                mySpeed = 20f;
                print("Tu velocidad es =" + mySpeed);
            }

              else if (ui.puntuacion >= 300 && ui.puntuacion <= 500)
            {
                mySpeed = 35f;
                print("Tu velocidad es =" + mySpeed);
            }

               else if (ui.puntuacion >= 500 && ui.puntuacion <= 700)
            {
                mySpeed = 40f;
                print("Tu velocidad es =" + mySpeed);
            }

          else if (ui.puntuacion >= 700 && ui.puntuacion <= 1000)
            {
                mySpeed = 50f;
                print("Tu velocidad es =" + mySpeed);
            }
            
            else if (ui.puntuacion >= 1000f)
            {
                mySpeed = 60f;
                print("Tu velocidad es =" + mySpeed);
            }
            
            yield return new WaitForSeconds(0.1f);

        } 

    }     */
}
