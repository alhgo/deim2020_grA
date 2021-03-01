using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    //Desaparece
    public MeshRenderer myMesh;
    private float moveSpeed= 10f;
    public float speed;
    [SerializeField] Text SpeedText;
    [SerializeField] Text DistanciaText;
    int distancia = 0;

    //Variables Restart
    public GameObject panelRestart;
    public Text record;
    // Start is called before the first frame update
    void Start()
    {
        //Llamo a la corrutina velocidad
        StartCoroutine("Velocidad");
        StartCoroutine("Distancia");

        //Ocultar panel Restart
        panelRestart.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        MoverNave();
        //SpeedText.text = speed.ToString();
        SpeedText.text = "Velocidad:"+speed+ "km/h";
        
    }
    IEnumerator Velocidad()
    {
        //Bucle infinito mientras sea verdad while (true)
        for(; ; )
        {
            //Límite hasta 20 y va sumando 0.1 cada segundo
            if (speed < 20)
            {
                speed = speed+0.1f;
            }
            //Ejecuto cada ciclo esperando 1 segundo
            yield return new WaitForSeconds(1f);
        }
    }

    void MoverNave()
    {
        moveSpeed = 10f + speed;
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        print(transform.position.x);
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");
        //Restringir mov horizontal
        if(PosX >-3 && PosX<3)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
       else if(PosX< -3 && desplX>0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        else if (PosX > 3 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        //Restringir mov vertical
        if (PosY > 1 && PosY < 5)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        else if (PosY < 1 && desplY > 0 )
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        else if (PosY > 5 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
       
    }
    //Método para la collision de la nave con las columnas
    private void OnCollisionEnter(Collision collision)
    {
        //Si se choca con un gameObject con el tag obstacle
        if (collision.gameObject.tag == "Obstacle")
        {
            //Que al chocar se detengan todos los obtstáculos y deje de avanzar la distancia recorrida
            speed = 0f;
            StopCoroutine("Velocidad");
            //Desaparecer
            myMesh.enabled = false;
            //Llamar método mostrarRestart
            mostrarRestart();


        }
    }
    IEnumerator Distancia()
    {
        distancia = 0;
        for (; ; )
        {

            distancia = (int)(distancia + speed*10);
            DistanciaText.text = "Distancia:" + distancia + "m";
            //Ejecuto cada ciclo esperando 1 segundo
            yield return new WaitForSeconds(1f);
        }
    }
    //Método para mostrar el panel Restart
    private void mostrarRestart()
    {
        SpeedText.text = "";
        DistanciaText.text = "";
        record.text = "Récord:" + distancia;

        panelRestart.SetActive(true);
    }
}
