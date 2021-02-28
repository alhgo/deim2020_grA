using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasscript : MonoBehaviour
{
    public Text timeText;
    public Text distancia;
    public Text velocidad;
    private Text Text;
    [SerializeField] GameObject Nave;
    private Sphere sphere;
    private float timePass;


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
        sphere = Nave.GetComponent<Sphere>();
        double lejitos = sphere.tiempodejuego * sphere.speed;

        string coorDistance = lejitos.ToString("f3");
        string coorSpeed = sphere.speed.ToString("f0");
        string total = sphere.tiempodejuego.ToString("f2");

        timeText.text = "Time: " + total;
        distancia.text = "Distance: " + coorDistance;
        velocidad.text = "Speed: " + coorSpeed;
    }

}
