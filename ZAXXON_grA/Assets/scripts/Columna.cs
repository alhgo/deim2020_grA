using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Columna : MonoBehaviour
{
    public GameObject Nave;
    private Sphere sphere;
    private Vector3 MyPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;

    public GameObject Timer;
    private Timer timer;
    
    //public GameObject puntuacion;
    
    float mySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        mySpeed = 20f;
        timer = Timer.GetComponent<Timer>();
        
        
        Debug.Log(timer.puntuacion);
        StartCoroutine("Dificultad");
        
    }


    void Update()
    {

     //movimiento de las colunas y su destrucción
       transform.Translate(Vector3.back * Time.deltaTime * mySpeed);
    
        if(transform.position.z < -20)
        {
            Destroy(gameObject);
        }

        
    }

     //dificultad incremental del juego (por corregir)
    IEnumerator Dificultad()
    {
        while (true)
            {
                if (timer.puntuacion <= 100)
                {
                    mySpeed = 20f;
                    print("Tu velocidad es =" + mySpeed);

                }

                else if (timer.puntuacion >= 100 && timer.puntuacion <= 300)
                {
                    mySpeed = 150f;
                    print("Tu velocidad es =" + mySpeed);
                }

                else if (timer.puntuacion >= 300 && timer.puntuacion <= 500)
                {
                    mySpeed = 75f;
                    print("Tu velocidad es =" + mySpeed);
                }

                else if (timer.puntuacion >= 500 && timer.puntuacion <= 700)
                {
                    mySpeed = 90f;
                    print("Tu velocidad es =" + mySpeed);
                }

                else if (timer.puntuacion >= 700 && timer.puntuacion <= 1000)
                {
                    mySpeed = 110f;
                    print("Tu velocidad es =" + mySpeed);
                }
                
                else if (timer.puntuacion >= 1000f)
                {
                    mySpeed = 130f;
                    print("Tu velocidad es =" + mySpeed);
                }
                
                yield return new WaitForSeconds(0.1f);

            } 

    }    
}
