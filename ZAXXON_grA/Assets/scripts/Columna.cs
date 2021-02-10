using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    private Sphere sphere;
    private Vector3 MyPos;
    [SerializeField] GameObject Nave;
    [SerializeField] float mySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Nave = GameObject.Find("Capsule");
    }

    // Update is called once per frame
    void Update()
    {
        Nave = GameObject.Find("Capsule");
        sphere = Nave.GetComponent<Sphere>();
        mySpeed = sphere.speed;
        
        Vector3 Movimiento = new Vector3(0, 0, -mySpeed);

        transform.Translate(Movimiento * Time.deltaTime * mySpeed);

        if (transform.position.z < -25)
        {
            Destroy(this.gameObject);
        }
    }
}
