using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    public GameObject[] Asteroides;
    [SerializeField] GameObject Empty;
    [SerializeField] GameObject Nave;
    private Transform RefPos;
    private Sphere mySpeed2;
    public float mySpeed;
    [SerializeField] float distObstacle;
    Vector3 newPos;
    private float incremento;


    void Start()
    {
        distObstacle = 5f;
        ObstacColum();
        StartCoroutine("ColumnCorrutine");
        StartCoroutine("BordesCorrutine");
    }

    // Update is called once per frame
    void Update()
    {
        mySpeed2 = Nave.GetComponent<Sphere>();

        if (mySpeed2.crearmeteoritos == false) {
            StopCoroutine("ColumnCorrutine");
            StopCoroutine("BordesCorrutine");
        }
    }

    void ObstacColum()
    {
        for (int n = 1; n <= 10; n++)
        {
            Empty = GameObject.Find("CrearColumnas");
            int r = Random.Range(10, Asteroides.Length);
            RefPos = Empty.GetComponent<Transform>();
            float randomX = Random.Range(-20f, 20f);
            float randomY = Random.Range(-20f, 20f);
            newPos = new Vector3(randomX, randomY, n * distObstacle);
            Vector3 finalPos = RefPos.position - newPos;
            Instantiate(Asteroides[r], finalPos, Quaternion.identity);
           
        }
    }

    void CrearColumna()
    {
        int r = Random.Range(0, Asteroides.Length);
        float posRandom = Random.Range(-20f, 20f);
        float randomY = Random.Range(-20f, 20f);
        Vector3 DestPos = new Vector3(posRandom, randomY, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        Instantiate(Asteroides[r], NewPos, Quaternion.identity);
    }


    void ColumnasBordes()
    {
        int r = Random.Range(0, Asteroides.Length);
        int s = Random.Range(0, 4);
        float posRandom = Random.Range(-15f, 15f);
        Vector3[] DestPos = new Vector3[] { new Vector3(posRandom, 20f , 0f), new Vector3(posRandom, -20f, 0f), new Vector3(20, posRandom, 0f), new Vector3(-20, posRandom, 0f) };
        Vector3 NewPos = RefPos.position + DestPos[s];
        Instantiate(Asteroides[r], NewPos, Quaternion.identity);
    }


    

    IEnumerator ColumnCorrutine()
    {
        for (int n = 0; ; n++)
        {
            CrearColumna();
            CrearColumna();
            yield return new WaitForSeconds(incremento / 2);
            CrearColumna();
            CrearColumna();
            mySpeed2 = Nave.GetComponent<Sphere>();
            incremento = 5/mySpeed2.speed;
            if (mySpeed2.speed > 13) { yield return new WaitForSeconds(incremento / 3); CrearColumna(); CrearColumna();}
            yield return new WaitForSeconds(incremento);
        }  
    }

    IEnumerator BordesCorrutine()
    {
        for (int n = 0; ; n++)
        {
            ColumnasBordes();
            ColumnasBordes();
            ColumnasBordes();
            mySpeed2 = Nave.GetComponent<Sphere>();
            incremento = 4 / mySpeed2.speed;
            if (mySpeed2.speed > 13) { yield return new WaitForSeconds(incremento / 3); ColumnasBordes(); ColumnasBordes(); }
            yield return new WaitForSeconds(incremento);
        }
    }
}
