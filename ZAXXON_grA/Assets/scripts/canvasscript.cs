using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasscript : MonoBehaviour
{
    public Text timeText;
    private Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sphere = GetComponent<Sphere>();
        double timePass = Time.time;
        string total = timePass.ToString("f0");
        timeText.text = total;
    }

   
}
