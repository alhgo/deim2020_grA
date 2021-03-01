using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Distance : MonoBehaviour
{
    public Text distanciaText;
    public float distancia = 0.0f;

    public void Update()
    {
        distancia += Time.deltaTime;
        distanciaText.text = "" + distancia.ToString("f0") + "m";
    }

}
