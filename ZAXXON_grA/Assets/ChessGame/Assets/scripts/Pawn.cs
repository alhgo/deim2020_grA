using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{

[SerilizeField] GameObject[] objetos;

Vector3 initPosWhite = new 


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objetos[0], initPosWhite, Quaternion.Euler(-90,0,90));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
