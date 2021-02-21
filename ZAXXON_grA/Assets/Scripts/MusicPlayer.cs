using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] AudioSource musicPlayer;
    [SerializeField] AudioClip[] cancion;
    [SerializeField] TextMeshProUGUI musicaPlaying;    
    int n;
    [SerializeField] Spaceship spaceship;
    // Start is called before the first frame update
    void Start()
    {   
        spaceship = gameObject.GetComponent<Spaceship>();
        int n = Random.Range(0,cancion.Length);
        musicPlayer.PlayOneShot(cancion[n]);
        musicaPlaying.SetText(cancion[n].name);
    }

    // Update is called once per frame
    void Update()
    {
        if(musicPlayer.isPlaying == false && spaceship.vidas >=0)
        {
            int n = Random.Range(0,cancion.Length);
            musicPlayer.PlayOneShot(cancion[n]);
            musicaPlaying.SetText(cancion[n].name);
        }
        
    }
}
