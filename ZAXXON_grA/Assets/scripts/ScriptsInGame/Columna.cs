using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    public GameObject InitGame;
    private InitGame initGame;
    public float velocidadcolumnas;
    private Vector3 MyPos;
   


    // Start is called before the first frame update
    void Start()
    {
        
        InitGame = GameObject.Find("InitGame");
        initGame = InitGame.GetComponent<InitGame>();

    }

    // Update is called once per frame
    void Update()
    { 


        //Movimiento de las columnas

        transform.Translate(Vector3.back * Time.deltaTime * initGame.velocidadnaves);
       
        //Destrucción de columnas

        if(transform.position.z < -10)
        {
            Destroy(gameObject);

        }
    }
    
    
    
}


