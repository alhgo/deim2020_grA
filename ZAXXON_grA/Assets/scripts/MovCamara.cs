﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovCamara : MonoBehaviour
{
    [SerializeField] Transform navePos;
    [SerializeField] float smoothSpeed = 0.01f;
    [SerializeField] Vector3 camSpeed = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
       // print(navePos);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = new Vector3(navePos.position.x, navePos.position.y +2.5f, navePos.position.z -6);
        transform.position = Vector3.SmoothDamp(transform.position, camPos, ref camSpeed, smoothSpeed);
     
    }
}
