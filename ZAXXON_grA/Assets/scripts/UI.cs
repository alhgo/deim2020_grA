
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
    public float playedTime;
    float tiempo;
    float segundos;
    float minutos;
   
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
        float puntuacion = playedTime * 20;
        TextoPuntuacion.text = "Puntuación: " + puntuacion.ToString("00");
        Vidas.text = "Vidas: " + initGame.vidas.ToString("00");
        


    }

    void ConversorTiempo()
    {
        {
            segundos = (int)playedTime % 60;
            minutos = (int)((playedTime / 60) % 60);
        }
    }
}
