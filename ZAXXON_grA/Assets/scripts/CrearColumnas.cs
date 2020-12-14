using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    public GameObject MyColumn;
    [SerializeField] Transform RefPos;
    //[SerializeField] float distObstacle;
    Vector3 newPos;
        
    // Start is called before the first frame update
    void Start()
    {
        //ObstacColum();
        StartCoroutine("ColumnCorrutine");

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void CrearColumna()
    {
        float posRandom = Random.Range(-13f, 13f);
        Vector3 DestPos = new Vector3(posRandom, 0, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        Instantiate(MyColumn, DestPos, Quaternion.identity);
    }
    /*
    void ObstacColum()
    {
        for (int nn = 1; ; nn++)
        {
            float randomX = Random.Range(-15f, 15f);
            newPos = new Vector3(randomX, 0, -nn * distObstacle);
            Vector3 finalPos = RefPos.position - newPos;
            Instantiate(MyColumn, finalPos, Quaternion.identity);
        }

    }*/

    IEnumerator ColumnCorrutine()
    {
        for (int n=0; ; n++ )
        {   
            CrearColumna();
            yield return new WaitForSeconds(0.15f);
        }
    }


  
}
