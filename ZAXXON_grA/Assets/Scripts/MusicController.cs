using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScripts : MonoBehaviour
{
    [SerializeField] AudioSource musicPlayer;
    [SerializeField] AudioSource SFXPlayer;
    float musicVolume, effectsVolume;
    // Start is called before the first frame update
    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("musicaVolumen");
        effectsVolume = PlayerPrefs.GetFloat("efectosVolumen");
        musicPlayer.volume = musicVolume;
        SFXPlayer.volume = effectsVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
