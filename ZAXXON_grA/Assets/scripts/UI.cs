
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
   public GameObject otroObjeto;
   private  Columna columna;
    public float playedTime;
    
   
    void Start(){
     playedTime = 0;
     columna = otroObjeto.GetComponent<Columna>();
        columna.mySpeed = 10f;
        columna.myNewSpeed = 10f;
        columna.SendMessage("AumentoVelocidad");
 }    
 
 void Update(){
     
     playedTime = Time.time * 10;
    AumentoVelocidad();
    print(columna.mySpeed + " es tu velocidad");
    print(playedTime + " es tu tiempo");
    columna.SendMessage("AumentoVelocidad");
    
 }

    public float AumentoVelocidad()
    {
       
        if(playedTime < 100)
        {
            columna.mySpeed = 10f;
            
        }

        else if(playedTime >= 50 && playedTime <= 100)
        {
            columna.mySpeed = 20f;
            
        }
        else if(playedTime >= 100 && playedTime <=  300) 
        {
            columna.mySpeed = 200f;
            
        }
        else if(playedTime >= 300 && playedTime <= 700) 
        {
            columna.mySpeed = 40f;
            
        }
        else if(playedTime >= 700 && playedTime <= 1000) 
        {
            columna.mySpeed = 50f;
            
        }
        else
        {
            columna.mySpeed = 60f;
            
        }
    
    return columna.mySpeed;
        
    }  
    
    
    
    
}
