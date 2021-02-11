using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{   
    public float timeStart;
    public Text textBox;
    private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
        void Update()
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");


         //Parar el tiempo con el start.
            if (Input.GetButtonDown("Start"))
            {
    
            if (paused)
                Time.timeScale = 1;
            else 
                Time.timeScale = 0;
            paused = !paused; 
            }
        }
}



