using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{

    public float speed ;
    public float dificultad;
    public bool alive;
    public float vidas = 3;


    // Start is called before the first frame update
    void Start()
    {
        speed = 30;
        dificultad = 10;
        alive = true;

    }

    // Update is called once per frame
    void Update()
    {
        AumentoDificultad();
        print(alive);
      
    }


    void AumentoDificultad()
    {


    }

   
   
}

