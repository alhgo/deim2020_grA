using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    public float velNaves;
    public float timeStart;
    public float puntuacion;
    [SerializeField] Text textBox;
    [SerializeField] Text textPunt;
    public bool paused = false;

    public GameObject Columna;
    private Columna columna;
    
    public GameOverManager gameOverManager;

    // Start is called before the first frame update
    void Start()
    {



        print(puntuacion);

        StartCoroutine("Dificultad");

    }

    // Update is called once per frame
    void Update()
    {

        
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
            puntuacion = timeStart * 20;
            textPunt.text = puntuacion.ToString("00");

         //Parar el tiempo con el start.
            if (Input.GetButtonDown("Start"))
            {
            if (paused)
                Time.timeScale = 1;
            else 
                Time.timeScale = 0;
            paused = !paused; 
            }
        
    }

            //dificultad incremental del juego (por corregir)
        IEnumerator Dificultad()
        {
            while(true)
                {
                    if (puntuacion <= 100)
                    {
                        velNaves = 20f;
                        print("Tu velocidad es =" + velNaves);
                    }

                    else if (puntuacion > 100 && puntuacion <= 300)
                    {
                        velNaves = 50f;
                        print("Tu velocidad es =" + velNaves);
                    }

                    else if (puntuacion > 300 && puntuacion <= 500)
                    {
                        velNaves = 75f;
                        print("Tu velocidad es =" + velNaves);
                    }

                    else if (puntuacion > 500 && puntuacion <= 700)
                    {
                        velNaves = 90f;
                        print("Tu velocidad es =" + velNaves);
                    }

                    else if (puntuacion > 700 && puntuacion <= 1000)
                    {
                        velNaves = 110f;
                        print("Tu velocidad es =" + velNaves);
                    }
                    
                    else if (puntuacion > 1000f)
                    {
                        velNaves = 130f;
                        print("Tu velocidad es =" + velNaves);
                    }
                    
                    yield return new WaitForSeconds(0.1f);
                } 
        }




}
