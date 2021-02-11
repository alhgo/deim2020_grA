
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public GameObject InitGame;
    private InitGame initGame;
    [SerializeField] Text TextoTiempo;
    [SerializeField] Text TextoPuntuacion;
    [SerializeField] Text Vidas;
    [SerializeField] Text TextoDificultad;
    public float playedTime;
    float tiempo;
    float segundos;
    float minutos;
    public float puntuacion;


    void Start()
    {
        initGame = InitGame.GetComponent<InitGame>();
        playedTime = 0;

    }

    void Update()
    {

        playedTime += Time.deltaTime;
        ConversorTiempo();
        TextoTiempo.text = "Tiempo en partida: " + minutos.ToString("00") + ":" + segundos.ToString("00");
        puntuacion = playedTime * 20;
        TextoPuntuacion.text = puntuacion.ToString("00");
        Vidas.text = "Vidas: " + initGame.vidas.ToString("00");


        if (initGame.dificultad <= 5)
        {
            TextoDificultad.text = "Dificultad: " + initGame.dificultad;
               
        }
        else
        {
            TextoDificultad.text = "Dificultad: MODO DIOS";


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
