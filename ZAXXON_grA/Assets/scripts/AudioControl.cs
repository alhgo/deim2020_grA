using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{

    AudioSource audioSource;

    [SerializeField] AudioClip disparo1;
    [SerializeField] AudioClip disparo2;
    [SerializeField] AudioClip disparo3;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            AlaCarga();
        }
    }

    void Disparar()
    {
        audioSource.PlayOneShot(disparo1, 1f);
        
    }
    void AlaCarga()
    {
        audioSource.PlayOneShot(disparo2, 0.5f);
    }
}
