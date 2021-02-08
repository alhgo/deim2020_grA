using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSuelo : MonoBehaviour
{
    
    public GameObject InitGame;
    private InitGame initGame;
    [SerializeField] float scrollSpeed;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        initGame = InitGame.GetComponent<InitGame>();
        scrollSpeed = - initGame.speed; 
        startPos = transform.position;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 100);
        transform.position = startPos + Vector3.forward * newPos;
        print(initGame.speed);
    }
}
