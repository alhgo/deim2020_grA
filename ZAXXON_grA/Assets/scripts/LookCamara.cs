﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamara : MonoBehaviour
{
    public GameObject Personaje;
    private Transform playerPosition;
    //Variables necesarias para la opción de suavizado
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Personaje.GetComponent<Transform>();
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y + 2, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }
}
