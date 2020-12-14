using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{

[SerilizeField] GameObject[] objetos;

Vector3 initPosWhite = new Vector3(-21, 0, 21);
Vector3 initPosBlack = new Vector3(-21, 0, 21);
Vector3 initPosPawn = new Vector3(-21, 0, 15);
    // Start is called before the first frame update
    void Start()
    {
            for(int n= 0; n < 8; n++){
                     Instantiate(objetos[0], initPosWhite, Quaternion.Euler(-90,0,90));
                initPosWhite = initPosWhite + new Vector3(6, 0, 0);
            }
       
             for(int p= 0; p < 8; p++){
                     Instantiate(objetos[0], initPosPawn, Quaternion.Euler(-90,0,90));
                initPosPawn = initPosPawn + new Vector3(6, 0, 0);


            for(int n= 0; n < 8; n++){
                     Instantiate(objetos[0], initPosBlack, Quaternion.Euler(-90,0,90));
                initPosBlack = initPosBlack + new Vector3(6, 0, 0);
            }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
