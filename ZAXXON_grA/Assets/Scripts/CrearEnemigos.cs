using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigos : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject[] MyEnemigo;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    public float timeEnemigo;
        
    // Start is called before the first frame update
    void Start()
    {
        //spaceship = Spaceship.GetComponent<Spaceship>();
        timeEnemigo = 0.08f;
        InicioEnemigo();
        StartCoroutine("EnemigoCorrutine");
        StartCoroutine("Dificultad");       
    }

    // Update is called once per frame
    void Update()
    {
    }

    void CrearEnemigo(int n)
    {
        //int n = Random.Range(0, 2);
        //Creo un nuevo vector3
        float posRandomX = Random.Range(-15f, 15f);
        float posRandomY = Random.Range(1.5f, 10f);
        Vector3 DestPos = new Vector3(posRandomX, posRandomY, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyEnemigo[n], NewPos, Quaternion.Euler(0,180,0));
    }

    void InicioEnemigo(){
        for (int i = 0; i < 40; i++)
        {
            int n = Random.Range(0,MyEnemigo.Length);
            float posRandomX = Random.Range(-15f, 15f);
            float posRandomY = Random.Range(1.5f, 10f);
            Vector3 posInic = new Vector3(posRandomX, posRandomY, -5*i);
            Vector3 posPrincipal = RefPos.position + posInic;
            Instantiate(MyEnemigo[n],posPrincipal, Quaternion.Euler(0,180,0));
        }
    }

    IEnumerator EnemigoCorrutine()
    {
        while(true)
        {
            int n = Random.Range(0,MyEnemigo.Length);
            CrearEnemigo(n);
            yield return new WaitForSeconds(timeEnemigo);
        }
    }

    //Código con ayuda de Adrián Gil    
    IEnumerator Dificultad()
    {      
        while(true)
        {
            print(timeEnemigo);  
            yield return new WaitForSeconds(40f);
            if(timeEnemigo >= 0.02f)
            {            
                timeEnemigo = timeEnemigo - 0.01f;
            }
            else{
                timeEnemigo = 0.01f;
            }
        }
    }

}