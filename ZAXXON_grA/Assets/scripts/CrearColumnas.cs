using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    //Distancia entre columnas
   [SerializeField] float distObstacle;
    Vector3 newPos;
    private float speed;
    private float temporizador;
    //Variables para asociarse con un gameObject y un Script de ese gameObject
    public GameObject Nave;
    private Sphere sphereMove;
    

    // Start is called before the first frame update
    void Start()
    {
        CrearColumnasIniciales();
        
        sphereMove = Nave.GetComponent<Sphere>();
        StartCoroutine("ColumnCorrutine");


    }

    // Update is called once per frame
    void Update()
    {
        if (sphereMove.speed != 0f) 
        {
            speed = sphereMove.speed;
        }
        else
        {
            StopCoroutine("ColumnCorrutine");
        }

    }
    void CrearColumnasIniciales()
    {
        distObstacle = 10f;
        for (int n = 1; n <= 17; n++)
        {
            float randomY = Random.Range(4.75f, 1f);
            float randomZ = Random.Range(-3.5f, 3.5f);
            Vector3 newPos = new Vector3(-randomZ, randomY, n * distObstacle);
            Vector3 finalPos = newPos + new Vector3(0,0,10);
            Instantiate(MyColumn, finalPos, Quaternion.identity);
        }
        
    }
    void CrearColumna()
    {
        //Creo un nuevo vector3
        
        float posRandomY = Random.Range(4.75f, 1f);
        float posRandom = Random.Range(-3.5f, 3.5f);
        Vector3 DestPos = new Vector3(posRandom, posRandomY, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }

    IEnumerator ColumnCorrutine()
    {

        for (int n=0; ; n++ )
        {
            print(n);
            CrearColumna();
            //Relación entre la velocidad de la nave y el tiempo para instanciar columnas
            temporizador = 1f - (speed * 0.04f);
            yield return new WaitForSeconds(temporizador);
        }
    }
   
}
