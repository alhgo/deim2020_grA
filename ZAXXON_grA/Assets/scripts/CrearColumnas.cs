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
    public float aumentoDificultadYield;
    

    public Columna columna;
    public GameObject InitGame;
    private InitGame initGame;

    void Start()
    {
        InitGame = GameObject.Find("InitGame");
        initGame = InitGame.GetComponent<InitGame>();

        columna = gameObject.GetComponent<Columna>();

        distcolumna = 10;

        StartCoroutine("ColumnCorrutine");

        InicioColumnas();
    }

    void Update()
    {
    }

    //creacion de columnas desde el fondo en bucle constante
        IEnumerator ColumnCorrutine()
       {
            for(int n = 0; ; n++)
            {
            //Aumento de dificultad que me ha enseñado adrian a como hacerlo.
            aumentoDificultadYield = initGame.velNaves * 0.00153020234f;
            CrearColumna();
            print(aumentoDificultadYield);
            yield return new WaitForSeconds(0.25f - aumentoDificultadYield);
            }
       }


        void CrearColumna()
            {
                float posRandomx = Random.Range(0f, 30f);
                float posRandomz = Random.Range(0f, 10f);
                float posRandomy = Random.Range(0f, 15f);
                Vector3 DestPos = new Vector3(posRandomx, posRandomy, posRandomz);
                Vector3 NewPos = RefPos.position + DestPos;
                Instantiate(MyColumn, NewPos, Quaternion.identity);
            }

    //creacion de planetas entre la nave y donde se generan de cero.
        void InicioColumnas()
        {
            for (int n = 0; n < 30; n++)
                {
                float posRandomx = Random.Range(0f, 30f);
                float posRandomz = Random.Range(0f, 30f);
                float posRandomy = Random.Range(0f, 14f);
                Vector3 NewPos = new Vector3(posRandomx, posRandomy, -n*distcolumna); 
                Vector3 finalPos = InitPos.position + NewPos;
                Instantiate(MyColumn, finalPos, Quaternion.identity);
                }
        }


}
