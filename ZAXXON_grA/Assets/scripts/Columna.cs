using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Columna : MonoBehaviour
{
    //public GameObject Nave;
    private Sphere sphere;
    private Vector3 MyPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;

    public float mySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        mySpeed = 20f;
    }


    void Update()
    {

     //movimiento de las colunas y su destrucción
       transform.Translate(Vector3.back * Time.deltaTime * mySpeed);
    
        if(transform.position.z < -20)
        {
            Destroy(gameObject);
        }
    }
}
