using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    [SerializeField] GameObject[] Asteroides;
    [SerializeField] GameObject Empty;
    private Transform RefPos;
    [SerializeField] float distObstacle;
    Vector3 newPos;
    

    void Start()
    {
        distObstacle = 5f;
        ObstacColum();
        StartCoroutine("ColumnCorrutine");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ObstacColum()
    {
        for (int n = 1; n <= 10; n++)
        {
            Empty = GameObject.Find("CrearColumnas");
            int r = Random.Range(10, Asteroides.Length);
            RefPos = Empty.GetComponent<Transform>();
            float randomX = Random.Range(-15f, 15f);
            float randomY = Random.Range(-15f, 15f);
            newPos = new Vector3(randomX, randomY, n * distObstacle);
            Vector3 finalPos = RefPos.position - newPos;
            Instantiate(Asteroides[r], finalPos, Quaternion.identity);
        }
    }

    void CrearColumna()
    {
        int r = Random.Range(0, Asteroides.Length);
        float posRandom = Random.Range(-15f, 15f);
        float randomY = Random.Range(-15f, 15f);
        Vector3 DestPos = new Vector3(posRandom, randomY, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        Instantiate(Asteroides[r], NewPos, Quaternion.identity);
    }

    //IMPORTANTE: el intevalo de creación ahora es fijo pero debería depender de la velocidad de la nave
    IEnumerator ColumnCorrutine()
    {
        for (int n = 0; ; n++)
        {
            CrearColumna();
            yield return new WaitForSeconds(0.15f);
        }
    }
}
