using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarPartida : MonoBehaviour
{
    public void EmpezarJuego()
    {
        SceneManager.LoadScene("SampleScene"); 
    }
    public void HighScores()
    {
        SceneManager.LoadScene("HighScores");
    }
}
