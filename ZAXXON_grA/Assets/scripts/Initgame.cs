using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initgame : MonoBehaviour
{
    [SerializeField] GameObject[] objetos;
    Vector3 initPos = new Vector3(-21, 0, 21); 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int r = Random.Range(0, objetos.Length);
        Instantiate(objetos[r], initPos, Quaternion.Euler(-90,90,0));
    }
}
