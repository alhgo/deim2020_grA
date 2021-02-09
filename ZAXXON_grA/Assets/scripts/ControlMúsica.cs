using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMúsica : MonoBehaviour
{

    
    public GameObject InitGame;
    private InitGame initGame;
     AudioSource audioSource;
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
    }

    void PararMusica(){

    if (initGame.alive == false)
        {
            audioSource.Stop();
           
        }
    }

}
