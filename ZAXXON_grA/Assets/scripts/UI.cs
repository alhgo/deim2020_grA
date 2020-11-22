using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] Columna columna;
    



float playedTime = 0;

void Start(){
     playedTime = 0;
 }    
 
 void Update(){
 
     playedTime = Time.time * 10;
     AumentoVelocidad();
 print (playedTime + " tu puntuacion");
 print (columna.mySpeed + " es tu velocidad");
 }
    
    void AumentoVelocidad()
    {
        
        if(playedTime <= 100)
        {
            columna.mySpeed = 300f;
        }
        else if(playedTime >= 300) 
        {
            columna.mySpeed = 4000f;
        }
        else if(playedTime <= 500) 
        {
            columna.mySpeed = 4000f;
        }
        else if(playedTime <= 700) 
        {
            columna.mySpeed = 4000f;
        }
        else if(playedTime <= 1000f) 
        {
            columna.mySpeed = 4000f;
        }

    }
    
}
