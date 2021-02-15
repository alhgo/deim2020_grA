using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigos : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject[] MyEnemigo;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
        
    // Start is called before the first frame update
    void Start()
    {
        InicioEnemigo();
        StartCoroutine("EnemigoCorrutine");
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    void CrearEnemigo()
    {
        //int n = Random.Range(0, 2);
        //Creo un nuevo vector3
        float posRandomX = Random.Range(-15f, 15f);
        float posRandomY = Random.Range(1.5f, 10f);
        Vector3 DestPos = new Vector3(posRandomX, posRandomY, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyEnemigo[2], NewPos, Quaternion.Euler(0,180,0));
    }

    void InicioEnemigo(){
        for (int n = 0; n < 45; n++)
        {
            float posRandomX = Random.Range(-15f, 15f);
            float posRandomY = Random.Range(1.5f, 10f);
            Vector3 posInic = new Vector3(posRandomX, posRandomY, -2*n);
            Vector3 posPrincipal = RefPos.position + posInic;
            Instantiate(MyEnemigo[2],posPrincipal, Quaternion.Euler(0,180,0));
        }
    }

    IEnumerator EnemigoCorrutine()
    {

        for (int n=0; ; n++ )
        {
            //print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn);
            CrearEnemigo();
            yield return new WaitForSeconds(0.1f);
        }
    }
}