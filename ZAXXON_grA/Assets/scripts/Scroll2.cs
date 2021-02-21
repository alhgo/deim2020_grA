using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll2 : MonoBehaviour
{
    public float speed = 30f;
    private Vector3 StartPosition;
       void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z < 143f)
        {
            transform.position = StartPosition;
        }
    }
}
