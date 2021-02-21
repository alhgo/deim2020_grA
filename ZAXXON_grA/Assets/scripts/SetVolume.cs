using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{

     public AudioMixer control;

    public void SetLevel (float SliderValue)
    {
        control.SetFloat("VolControl", Mathf.Log10 (SliderValue) * 20 );
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
