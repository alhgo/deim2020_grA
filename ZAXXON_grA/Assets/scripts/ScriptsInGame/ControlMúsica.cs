using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMúsica : MonoBehaviour
{

    
    public GameObject InitGame;
    private InitGame initGame;
    [SerializeField] AudioSource audioSource;
    public AudioClip[] playlistMusical;
    public int pistaActualMusica;

    // Start is called before the first frame update
    void Start()
    {
        initGame = InitGame.GetComponent<InitGame>();
        audioSource = GetComponent<AudioSource>();

       
        
    }

    // Update is called once per frame
    void Update()
    {
        PararMusica();
        MusicaAleatoria();
    }

    void PararMusica(){

    if (initGame.alive == false)
        {
            audioSource.Stop();
           
        }
    }

//Selector aleatorio de la música del nivel.

    void MusicaAleatoria(){

        if (audioSource.isPlaying == false)
        {
            pistaActualMusica = Random.Range(0,playlistMusical.Length);
            audioSource.PlayOneShot(playlistMusical[pistaActualMusica], 0.35f);
        }
    }

}
