using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    [SerializeField] GameObject[] whites;
    [SerializeField] GameObject[] blacks;

    Vector3 initPosW = new Vector3(-21, 0, 21);
    Vector3 initPosB = new Vector3(-21, 0, -21);

    Vector3 sumPos = new Vector3(6, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        int i;

        for (i = 0; i < 8; i++)
        {
            //int r = Random.Range(0, objetos.Length);
            Instantiate(whites[i], initPosW, Quaternion.Euler(-90, 90, 0));
            initPosW = initPosW + sumPos;

            Instantiate(blacks[i], initPosB, Quaternion.Euler(-90, -90, 0));
            initPosB = initPosB + sumPos;

        }

    }


}
