using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    public GameObject Nave;
    public Sphere sphere;

    private Vector3 MyPos;
    [SerializeField] float mySpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        Nave = GameObject.Find("Sphere");

        
        sphere = Nave.GetComponent<Sphere>();
        mySpeed = sphere.speed*2.5f;
    }

    // Update is called once per frame
    void Update()
    {
       if(sphere.speed != 0f)
        {
           
            transform.Translate(Vector3.back * Time.deltaTime * mySpeed);

            if (transform.position.z < -10)
            {
                Destroy(gameObject);
            }
        }
    }
}
