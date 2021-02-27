using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed = 8f;
    [SerializeField] GameObject Nave;
    [SerializeField] Renderer Navemesh;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("AumentoVelocidad");
       
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
        
        Nave.GetComponent<Renderer>();
        Navemesh.enabled = false;
    }



}
