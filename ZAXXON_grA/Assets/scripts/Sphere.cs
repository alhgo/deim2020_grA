using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed = 8f;
    [SerializeField] GameObject Nave;
    [SerializeField] GameObject Canvasscript;
    [SerializeField] Renderer Navemesh;
    [SerializeField] GameObject Explosion;
    public float tiempodejuego;
    public bool crearmeteoritos = true;
    public GameObject GOCanvas;
    public GameObject Llamitas;

    // Start is called before the first frame update
    void Start()
    {
        tiempodejuego = 0.00f;
        StartCoroutine("AumentoVelocidad");
        StartCoroutine("Tiempojuego");
       
    }

    // Update is called once per frame
    void Update()
    {
		MoverNave();		
        if (speed == 18f) { StopCoroutine("AumentoVelocidad"); };
    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        if (PosX > -13 && PosX < 13 || PosX < -13 && desplX > 0 || PosX > 13 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        if (PosY > -13 && PosY < 13 || PosY < -13 && desplY > 0 || PosY > 13 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
      }

    IEnumerator AumentoVelocidad()
    {
        for (int n = 0; ; n++)
        {
            yield return new WaitForSeconds(5f);
            speed = speed + 1;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Expljuego");
    }

    IEnumerator Expljuego()
    {
        for (int n = 0; n <= 3 ; n++)
        {
            if (n == 0) { 
                Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                crearmeteoritos = false;
                Llamitas.SetActive(false);
                Nave.GetComponent<Renderer>();
                Navemesh.enabled = false;
            }
            else if (n < 3) 
            { 
                StopCoroutine("AumentoVelocidad");
                StopCoroutine("Tiempojuego");
            }
            else
            {
                GOCanvas.SetActive(true);
                Time.timeScale = 0f;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator Tiempojuego()
    {
        for (int n = 0; ; n++)
        {
            tiempodejuego = tiempodejuego + 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
    }

}
