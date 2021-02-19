using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerMenu : MonoBehaviour
{

     [SerializeField] AudioSource audioSource;
    public AudioClip[] playlistMusical;
    public int pistaActualMusica;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        MusicaAleatoria();
        
    }
        
        void MusicaAleatoria(){

        
            if (audioSource.isPlaying == false)
            {
                pistaActualMusica = Random.Range(0,playlistMusical.Length);
                audioSource.PlayOneShot(playlistMusical[pistaActualMusica], 0.35f);
            }
        }
}
