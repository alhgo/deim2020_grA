using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSuelo : MonoBehaviour
{
    
    public GameObject Columna;
    private Columna columna;
    [SerializeField] float scrollSpeed;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        columna = Columna.GetComponent<Columna>();
        scrollSpeed = -columna.mySpeed; 
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 100);
        transform.position = startPos + Vector3.forward * newPos;
    }
}
