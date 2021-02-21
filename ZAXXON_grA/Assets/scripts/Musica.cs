using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{

    public AudioSource musicPlayer;
    public AudioClip[] cancion;

    public Sphere sphere;


//reproducir las canciones aleatoriamente desde el inicio
    void Start()
    {
        sphere = gameObject.GetComponent<Sphere>();
        int n = Random.Range(0,cancion.Length);
        musicPlayer.PlayOneShot(cancion[n], 0.2f);
    }

//cada vez que una cancion se acabe que reproduzca otra aleatoriamente.
    void Update()
    {
        if(musicPlayer.isPlaying == false && sphere.life >1)
        {
            int n = Random.Range(0,cancion.Length);
            musicPlayer.PlayOneShot(cancion[n], 0.6f);
        }
    }

}
