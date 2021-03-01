using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musiccript : MonoBehaviour
{
    public AudioClip musica;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
      
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musica;
        audioSource.volume = 0.3f;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
