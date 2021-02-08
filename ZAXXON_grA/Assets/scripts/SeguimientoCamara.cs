using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{

    [SerializeField] Transform posicionJugador;
    [SerializeField] float smoothVelocity = 30f;
    [SerializeField] Vector3 cameraVelocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(posicionJugador.position.x, posicionJugador.position.y + 4f, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraVelocity, smoothVelocity);
        
    }
}
