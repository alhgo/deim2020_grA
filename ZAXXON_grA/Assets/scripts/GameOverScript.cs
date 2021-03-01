using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject GOCanvas;
    [SerializeField] Text distancia;
    [SerializeField] GameObject Nave;
    private Sphere sphere;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    void Update()
    {
        TextoGameOver();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void BackMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void TextoGameOver()
    {
        sphere = Nave.GetComponent<Sphere>();

        double lejitos = sphere.tiempodejuego * sphere.speed;
        string coorDistance = lejitos.ToString("f2");

        distancia.text = "Distance: " + coorDistance;

    }
}