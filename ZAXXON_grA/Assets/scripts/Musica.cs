using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{

    [SerializeField] AudioSource musicPlayer;
    [SerializeField] AudioClip[] cancion;
    [SerializeField] AudioClip[] golpes;

    public Sphere sphere;

//reproducir las canciones aleatoriamente desde el inicio
    void Start()
    {
        int n = Random.Range(0,cancion.Length);
        musicPlayer.PlayOneShot(cancion[n], 0.2f);
        //pararMusica();
            
    }

//cada vez que una cancion se acabe que reproduzca otra aleatoriamente.
    void Update()
    {
        if(musicPlayer.isPlaying == false)
        {
            int n = Random.Range(0,cancion.Length);
            musicPlayer.PlayOneShot(cancion[n], 0.6f);
        }
    }

//para la musica con la muerte del personaje (NO FUNCIONA ARREGLAR)
    void pararMusica()
            {
            if(sphere.life < 1)
            {
                musicPlayer.Stop();
            }
            }
}
