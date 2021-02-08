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
        CrearColumnaInicio();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void CrearColumnaInicio()
    {
      
        
        for (int n = 0; n <= 100; n++ )
        {
            float posRandom = Random.Range(-15, 15);
            float posRandomLejania = Random.Range(-270, -10);
            float posRandomAltura = Random.Range(3, 14);
            Vector3 DestPos = new Vector3(posRandom, posRandomAltura, posRandomLejania);
            Vector3 NewPos = RefPos.position + DestPos;
            Instantiate(MyColumn, NewPos, Quaternion.identity);
        }
    }
    void CrearColumna()
    {
        //Creo un nuevo vector3
        float posRandomAltura = Random.Range(3, 14);
        float posRandom = Random.Range(-15, 15);
        Vector3 DestPos = new Vector3(posRandom, posRandomAltura, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }


    //Corrutina de instanciador de columnas
    IEnumerator ColumnCorrutine()
    {

        for (int n=0; ; n++ )
        {
            CrearColumna();
            yield return new WaitForSeconds(0.09f);
           
        }
    }
}
