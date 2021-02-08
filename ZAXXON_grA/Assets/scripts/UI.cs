
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public float playedTime;

void Start(){
     
     playedTime = 0;
      
 }    
 
 void Update(){
     
     playedTime = Time.time * 10;
    
    print(playedTime + " es tu tiempo");

    
 } 
}
