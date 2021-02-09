using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{


    public GameObject InitGame;
    private InitGame initGame;
    public float speednave;
    [SerializeField] MeshRenderer visibilidadnave;
    [SerializeField] MeshRenderer visibilidadesfera;
    AudioSource audioSource;

    //Componentes nave para destrucción.

    [SerializeField] GameObject Lucesyparticulas;
    
    
    
    
    
    void Start()
    {
        initGame = InitGame.GetComponent<InitGame>();
        transform.position = new Vector3(0, 2, 0);
        speednave = 10;
        audioSource = GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        //Método para mover la nave con el joystick
        MoverNave();
       
       //Restar vidas al golpear.
       RestarVidas();

       //Parar el juego al llevar 0 vidas.
        AliveOrDead();
        
    }

    
//Movimiento de la nave con el mando. Restricciones y rotación.
    void MoverNave()
        {
       
        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        //Restringir movimiento en el eje X y parte del codigo de Iris (SpaceWorld y rotación)
        if (posX < 14 && posX > -14 || posX < -14 && desplX > 0 || posX > 14 && desplX < 0)
        {
             transform.Translate(Vector3.right * Time.deltaTime * speednave * desplX, Space.World);
        }

        //Restringir movimiento en el eje Y
        if (posY < 10 && posY > 1 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speednave * desplY, Space.World);
        }
         
        //Rotación nave
         transform.rotation = Quaternion.Euler(desplY * -10, 0 , desplX * -20);
         
        }

//Detección de colisión solo con los coches
    void OnTriggerEnter(Collider target)
        {
            if(target.gameObject.tag == "Enemigo")
            {              
                initGame.vidas --; 
                print(initGame.vidas);  
            }
            
        }
//Restar las vidas al chocar   
    void RestarVidas()
        {

         if (initGame.vidas == 0)
         {
        initGame.alive = false;
            }
        }
//Pregunta al juego si estas vivo o muerto para actuar.
    void AliveOrDead()
        {
        if (initGame.alive == false)
        {
            
            speednave = 0;
            visibilidadnave.enabled = false;
            visibilidadesfera.enabled = false;
            Destroy(Lucesyparticulas);
            
        }
         }
    


}

