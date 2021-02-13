using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotones : MonoBehaviour
{
    //Para saber de dónde viene el sonido
    public AudioSource fuente;
    //Qué sonido tiene que emitir
    public AudioClip sonido;
    // Start is called before the first frame update
    void Start()
    {
        fuente.clip = sonido;
    }

    // Update is called once per frame
    public void Reproducir()
    {
        fuente.Play();
    }
}
