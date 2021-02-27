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
    [SerializeField] GameObject Empty;
    private CrearColumnas Meteoritos;

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
        Velocidadmeteoritos();
        
        Vector3 Movimiento = new Vector3(0, 0, -mySpeed);

        transform.Translate(Movimiento * Time.deltaTime * mySpeed);

        if (transform.position.z < -25)
        {
            Destroy(this.gameObject);
        }
    }

    void Velocidadmeteoritos()
    {
        Nave = GameObject.Find("Capsule");
        sphere = Nave.GetComponent<Sphere>();
        Empty = GameObject.Find("CrearColumnas");
        Meteoritos = Empty.GetComponent<CrearColumnas>();
        int r = Random.Range(0, Meteoritos.Asteroides.Length);
        int rank = Meteoritos.Asteroides.Rank;
        if (rank < 7) { mySpeed = sphere.speed * 1.3f;}
        else if (rank < 7 || rank > 0) { mySpeed = sphere.speed * 1f; }
        else { mySpeed = sphere.speed * 0.6f; }
    }
    }

