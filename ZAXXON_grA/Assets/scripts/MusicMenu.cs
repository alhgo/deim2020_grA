using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
     [SerializeField] AudioSource musicPlayer;
    [SerializeField] AudioClip[] cancion;

    // Start is called before the first frame update
    void Start()
    {
         int n = Random.Range(0,cancion.Length);
        musicPlayer.PlayOneShot(cancion[n]);
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
}
