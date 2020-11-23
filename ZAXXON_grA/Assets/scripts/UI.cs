using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] Columna columna;
    



public float playedTime = 0;
public float medidorDificultad;
void Start(){
     playedTime = 0;
 }    
 
 void Update(){
 
     playedTime = Time.time * 10;


 }
   /* 
    void AumentoVelocidad()
    {
        columna.mySpeed = 10f;

        for(playedTime; playedTime == 200 + Time)

        /*
        if(playedTime >= 100)
        {
            columna.mySpeed = 20f;
        }
        else(playedTime >= 300) 
        {
            columna.mySpeed = 35f;
        }
        else(playedTime >= 500) 
        {
            columna.mySpeed = 40f;
        }
        else(playedTime >= 700) 
        {
            columna.mySpeed = 50f;
        }
        else(playedTime >= 1000f) 
        {
            columna.mySpeed = 60f;
        }
        
    }
    */
}
