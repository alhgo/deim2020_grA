using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ColumnCorrutine");
        InicioColumnas();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CrearColumna();
        }

    }

    void CrearColumna()
    {
        //Creo un nuevo vector3
        float posRandomx = Random.Range(0f, 40f);
        float posRandomz = Random.Range(0f, 0f);
        float posRandomy = Random.Range(0f, 18f);
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
           
            yield return new WaitForSeconds(0.1f);


        }
    }

    void InicioColumnas()
    {for (int n = 0; n < 5; n++)
    {
        float posRandomx = Random.Range(0f, 30f);
        float posRandomz = Random.Range(0f, -100f);
        float posRandomy = Random.Range(0f, 18f);
        Vector3 NewPos = new Vector3(posRandomx, posRandomy, posRandomz); 
        Vector3 finalPos = RefPos.position + NewPos;
        Instantiate(MyColumn, finalPos, Quaternion.identity);        
         }     
         }

}
