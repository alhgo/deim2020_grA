using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    //velocidad de movimiento de la nave, no de las columnas
    private float speed = 25f;
    private Rigidbody rb;
    public GameObject[] vidas;
    public int life = 3;
    [SerializeField] AudioSource musica;
    [SerializeField] AudioClip golpe;
    [SerializeField] AudioClip explosion;
    [SerializeField] AudioClip muerte;

    // Start is called before the first frame update
    void Start()
    {
        life = vidas.Length;
    }


    void Update()
    {
        
        //llamar a destruir vidas
        DestruirVidas();

        //llamar a mover nave
        MoverNave();


    }
    
    //mov nave 
    void MoverNave()
    {
        //dar mov
         float posX = transform.position.x;         
         float posY = transform.position.y;       
         float desplY = Input.GetAxis("Vertical"); 
         float desplX = Input.GetAxis("Horizontal");

        //restringir mov
         if (posX < 15 && posX > -15  || posX < -15 && desplX > 0 || posX > 15 && desplX < 0)        
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }
        if (posY < 10 && posY > 1 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)        
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }
    
        //rotacion nave al virar
        transform.rotation = Quaternion.Euler(0, 0, desplX * -20);
    }


    //colision de nave con planetas, resta de vidas por colision y sonido de colisiones y explosion.
    void OnTriggerEnter(Collider other)
    {
            if(other.gameObject.tag == "enemy")
            {
                life--;


                if(life < 3 && life > 0)
                {  
                    musica.PlayOneShot(golpe, 1f);
                }
                
                else
                {  
                    musica.PlayOneShot(explosion, 1f);
                }
            }
    }

    //Destruccion de los sprites y de la nave en funcion de la cantidad de vidas, llamada al canvas de gameover, parar musica y reproducir una nueva.
    void DestruirVidas()
    {
        if (life <= 0)
        {
            Destroy(vidas[0].gameObject);
            GameOverManager.gameOverManager.CallGameOver ();
            musica.Stop();
            musica.PlayOneShot(muerte, 1f);
            Destroy(gameObject);
        }

        else if (life < 2)
        {
            Destroy(vidas[1].gameObject);
        }

        else if (life < 3)
        {
            Destroy(vidas[2].gameObject);
        }
        
    }

 }

