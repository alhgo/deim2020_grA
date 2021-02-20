using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{   

    public float timeStart;
    public float puntuacion;
    [SerializeField] Text textBox;
    [SerializeField] Text textPunt;
    public bool paused = false;
    
    public GameOverManager gameOverManager;


    // Start is called before the first frame update
    void Start()
    {
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






     //Parar el tiempo con la muerte del personaje.
     /*No se puede usar esta forma porque el freezear el tiempo supone detener el juego completamente y por tanto también las lecturas de los scripts,
     luego si lo que quiero es que en la escena de gameover me ponga el tiempo cuando muero y para eso lo paro, no va a funcionar, 
     pero está bien saber la forma de detener el juego si muere el personaje*/
        
        /*void DeathTime()
        {
            if(sphere.life < 1)
            {
               Time.timeScale = 0f;
               Debug.Log(timeStart);
            }
        }*/
        
    

    
}



