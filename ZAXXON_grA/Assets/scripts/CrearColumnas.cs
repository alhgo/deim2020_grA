using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    [SerializeField] Transform InitPos;
    private float distcolumna;

    void Start()
    {   
        distcolumna = 10;
        StartCoroutine("ColumnCorrutine");
        InicioColumnas();
    }

    void Update()
    {
    }

    //creacion de columnas desde el fondo en bucle constante
        void CrearColumna()
        {
            float posRandomx = Random.Range(0f, 30f);
            float posRandomz = Random.Range(0f, 10f);
            float posRandomy = Random.Range(0f, 30f);
            Vector3 DestPos = new Vector3(posRandomx, posRandomy, posRandomz);
            Vector3 NewPos = RefPos.position + DestPos;
            //Instancio el prefab en la posición del objeto de referencia
            //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
            Instantiate(MyColumn, NewPos, Quaternion.identity);
        }

        IEnumerator ColumnCorrutine()
        {

            for (int n=0; ; n++ )
            {
            
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn);
            CrearColumna();
           
            yield return new WaitForSeconds(0.2f);
            }
        }

    //creacion de planetas entre la nave y donde se generan de cero.
        void InicioColumnas()
        {
            for (int n = 0; n < 30; n++)
            {
            float posRandomx = Random.Range(0f, 30f);
            float posRandomz = Random.Range(0f, 30f);
            float posRandomy = Random.Range(0f, 30f);
            Vector3 NewPos = new Vector3(posRandomx, posRandomy, -n*distcolumna); 
            Vector3 finalPos = InitPos.position + NewPos;
            Instantiate(MyColumn, finalPos, Quaternion.identity);
            }
        }

}
