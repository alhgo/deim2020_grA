using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
     public GameObject InitGame;
    private InitGame initGame;
    // Start is called before the first frame update
    void Start()
    {
         InitGame = GameObject.Find("InitGame");
         initGame = InitGame.GetComponent<InitGame>(); 
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * initGame.velocidadnaves, Space.World);
     
         if(transform.position.z < -10)
        {
            Destroy(gameObject);

        }
    }
}
