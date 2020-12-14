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
        InicioColumnas();
        StartCoroutine("ColumnCorrutine");
       
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
        float posRandom = Random.Range(-15f, 15f);
        Vector3 DestPos = new Vector3(posRandom, 0, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }

    void InicioColumnas(){
        for (int n = 0; n < 45; n++)
        {
            float posRandom = Random.Range(-15f, 15f);
            Vector3 posInic = new Vector3(posRandom, 0, -5*n);
            Vector3 posPrincipal = RefPos.position + posInic;
            Instantiate(MyColumn,posPrincipal, Quaternion.identity);
        }
    }

    IEnumerator ColumnCorrutine()
    {

        for (int n=0; ; n++ )
        {
            //print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn);
            CrearColumna();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
