using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    public GameObject Nave;
    private Sphere sphere;

    private Vector3 MyPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;

    
    float mySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
       //sphere = GetComponent<Sphere>();
        //mySpeed = sphere.speed;
        mySpeed = 50f;
        //print(mySpeed);
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.back * Time.deltaTime * mySpeed);
        //print(MyPos);

        if(transform.position.z < -20)
        {
            Destroy(gameObject);
        }
    }
}
