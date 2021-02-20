using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControlVolumenGlobal : MonoBehaviour
{

    public AudioMixer controladorVolumen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void ControlSlider(float valorSlider)
{

 controladorVolumen.SetFloat("VolumenGlobal", Mathf.Log10 (valorSlider) * 20 );

}
    
}
