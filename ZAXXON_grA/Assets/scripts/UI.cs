
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public GameObject InitGame;
    private InitGame initGame;
    public Text TextoPuntuacion;
    

    public float puntuacionfinal;
    public float playedTime;
    float tiempo;
    float segundos;
    float minutos;
    public float puntuacion;


    void Start()
    {
        initGame = InitGame.GetComponent<InitGame>();
        StartCoroutine("ContadorPuntuacion");
        

    }

    void Update()
    {

        playedTime += Time.deltaTime;
        ConversorTiempo();        
        
        print(initGame.vidas);
        
        if(initGame.vidas > 0)
        {
         TextoPuntuacion.text = puntuacion.ToString("00");
        }
        else if(initGame.vidas <= 0)
        {
            TextoPuntuacion.text = puntuacionfinal.ToString("00");
        }
    }

    IEnumerator ContadorPuntuacion()
    {
        while(true)
        {
            
         puntuacion = playedTime * 20;   
         
         yield return new WaitForSeconds(0.09f);
        }   
    }

    void ConversorTiempo()
    {
        {
            segundos = (int)playedTime % 60;
            minutos = (int)((playedTime / 60) % 60);
        }
    }

}
