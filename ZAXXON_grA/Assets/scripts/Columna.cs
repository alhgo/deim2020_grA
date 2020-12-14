using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    private Sphere sphere;
    private Vector3 MyPos;


    [SerializeField] float mySpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 Movimiento = new Vector3(0, 0, -mySpeed);

        transform.Translate(Movimiento * Time.deltaTime * mySpeed);

        if (transform.position.z < -25)
        {
            Destroy(this.gameObject);
        }
    }
}
