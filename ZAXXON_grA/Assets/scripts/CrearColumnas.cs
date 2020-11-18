using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    
    [SerializeField] int numeroColumna = 4;
    // Start is called before the first frame update
    void Start()
    {
        
        CrearColumnaIniciales();
        
        StartCoroutine("ColumnCorrutine");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void CrearColumnaIniciales()
    {
        for (int i = 1; i < numeroColumna; i++)
        {
            //Creo un nuevo vector3
            float posRandom = Random.Range(-9.5f, 9.5f);
            float posProg2 = 0f - 25f * i;


            //Instancio el prefab en la posición del objeto de referencia
            //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición



                //Instancio el prefab en la posición del objeto de referencia
                //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición

                Vector3 DestPos = new Vector3(posRandom, 0, posProg2);
                Vector3 NewPos = RefPos.position + DestPos;
                Instantiate(MyColumn, NewPos, Quaternion.identity);
                
            
            
        }
    }

    void CrearColumna()
    {
        float posRandom = Random.Range(-9.5f, 9.5f);
        Vector3 DestPos2 = new Vector3(posRandom, 0, 0);
        Vector3 NewPos2 = RefPos.position + DestPos2;
        Instantiate(MyColumn, NewPos2,Quaternion.identity);
    }
       IEnumerator ColumnCorrutine()
    {

        for (int n=0; ; n++ )
        {
            print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn);
            CrearColumna();
            yield return new WaitForSeconds(1);
        }
    }
}
