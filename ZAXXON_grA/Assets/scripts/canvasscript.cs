using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasscript : MonoBehaviour
{
    public Text timeText;
    public Text posX;
    public Text posY;
    private Text Text;
    [SerializeField] GameObject Nave;
    private Sphere sphere;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextosdelUI();
    }

   void TextosdelUI()
    {
        Nave = GameObject.Find("Capsule");
        Nave.GetComponent<Transform>();
        float PosX = Nave.transform.position.x;
        float PosY = Nave.transform.position.y;
        double timePass = Time.time;
        string coorX = PosX.ToString("f0");
        string coorY = PosY.ToString("f0");
        string total = timePass.ToString("f5");
        timeText.text = "Time: " + total;
        posX.text = "X: " + coorX;
        posY.text = "Y: " + coorY;
    }
}
