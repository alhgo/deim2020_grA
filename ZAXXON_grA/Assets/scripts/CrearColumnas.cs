using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;

    private Vector3 initPos, savedPos;
    private Vector3 nPos = new Vector3(0f, 0f, -10f);


    // Start is called before the first frame update
    void Start()
    {
        float n;
        initPos = transform.position;
        savedPos = transform.position;
              
        for(n= 0; n<10; n++)
        {
            initPos += nPos;
            transform.position = initPos;
            CrearColumna();
        }

        transform.position = savedPos;

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
        float posRandom = Random.Range(0f, 30f);
        Vector3 DestPos = new Vector3(posRandom, 0, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }

    IEnumerator ColumnCorrutine()
    {
        int n;
        for (n=0; ; n++ )
        {
            //print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn);
            CrearColumna();
            yield return new WaitForSeconds(1);
        }
    }
}
