using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{

    [SerializeField] AudioSource musicPlayer;
    [SerializeField] AudioClip[] cancion;
    [SerializeField] AudioClip[] golpes;

    public Sphere sphere;


    void Start()
    {
        int n = Random.Range(0,cancion.Length);
        musicPlayer.PlayOneShot(cancion[n]);
        pararMusica();
            
    }

    // Update is called once per frame
    void Update()
    {
        if(musicPlayer.isPlaying == false)
        {
            int n = Random.Range(0,cancion.Length);
            musicPlayer.PlayOneShot(cancion[n]);
        }
    }

    void sonidoColisiones()
    {
        if(sphere.gameObject.tag == "enemy" && sphere.life < 3)
        {  
            musicPlayer.PlayOneShot(golpes[2]);
        }
        
        else if(sphere.gameObject.tag == "enemy" && sphere.life < 2)
        {
            musicPlayer.PlayOneShot(golpes[1]);
        }

        else if (sphere.gameObject.tag == "enemy" && sphere.life < 1);
        {
            musicPlayer.PlayOneShot(golpes[0]);
        }
    }

    void pararMusica()
            {
            if(sphere.life < 1)
            {
                musicPlayer.mute = !musicPlayer.mute;
            }
            }
   
}
