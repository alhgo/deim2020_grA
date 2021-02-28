using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scriptmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SalirJuego()
    {
        Application.Quit();
    }

    public void EmpezarPartida()
    {
        SceneManager.LoadScene(1);
    }

    public void HighScores()
    {
        SceneManager.LoadScene(2);
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }
}
