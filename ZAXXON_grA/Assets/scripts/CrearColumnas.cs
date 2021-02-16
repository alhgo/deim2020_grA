using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    [SerializeField] Transform InitPos;
    private float distcolumna;

   
 

    void Start()
    {   
        distcolumna = 10;
        StartCoroutine("ColumnCorrutine");
        InicioColumnas();
        //StartCoroutine("Dificultad");

    }

    void Update()
    {
    }

    //creacion de columnas desde el fondo en bucle constante
        IEnumerator ColumnCorrutine()
            {

                for (int n=0; ; n++ )
                {
                
                //Intancio el prefab en coordenadas 0,0,0
                //Instantiate(MyColumn);
                CrearColumna();
                {
                    yield return new WaitForSeconds(0.4f);
                }
                }
            }

            
            void CrearColumna()
            {
                float posRandomx = Random.Range(0f, 30f);
                float posRandomz = Random.Range(0f, 10f);
                float posRandomy = Random.Range(0f, 30f);
                Vector3 DestPos = new Vector3(posRandomx, posRandomy, posRandomz);
                Vector3 NewPos = RefPos.position + DestPos;
                Instantiate(MyColumn, NewPos, Quaternion.identity);
            }

       

    //creacion de planetas entre la nave y donde se generan de cero.
        void InicioColumnas()
        {
            for (int n = 0; n < 30; n++)
            {
            float posRandomx = Random.Range(0f, 30f);
            float posRandomz = Random.Range(0f, 30f);
            float posRandomy = Random.Range(0f, 30f);
            Vector3 NewPos = new Vector3(posRandomx, posRandomy, -n*distcolumna); 
            Vector3 finalPos = InitPos.position + NewPos;
            Instantiate(MyColumn, finalPos, Quaternion.identity);
            }
        }

        //dificultad incremental del juego (por corregir)
    /*IEnumerator Dificultad()
    {
        for (int n = 0; ; n++)
            {
                if (timer.puntuacion <= 100)
                {
                    columna.mySpeed = 20f;
                    print("Tu velocidad es =" + columna.mySpeed);
                }

                else if (timer.puntuacion >= 100 && timer.puntuacion <= 300)
                {
                    columna.mySpeed = 50f;
                    print("Tu velocidad es =" + columna.mySpeed);
                }

                else if (timer.puntuacion >= 300 && timer.puntuacion <= 500)
                {
                    columna.mySpeed = 75f;
                    print("Tu velocidad es =" + columna.mySpeed);
                }

                else if (timer.puntuacion >= 500 && timer.puntuacion <= 700)
                {
                    columna.mySpeed = 90f;
                    print("Tu velocidad es =" + columna.mySpeed);
                }

                else if (timer.puntuacion >= 700 && timer.puntuacion <= 1000)
                {
                    columna.mySpeed = 110f;
                    print("Tu velocidad es =" + columna.mySpeed);
                }
                
                else if (timer.puntuacion >= 1000f)
                {
                    columna.mySpeed = 130f;
                    print("Tu velocidad es =" + columna.mySpeed);
                }
                
                yield return new WaitForSeconds(0.1f);

            } 

    }    */
        
}
