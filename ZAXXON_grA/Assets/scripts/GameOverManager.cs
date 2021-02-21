using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    
    public static GameOverManager gameOverManager;
    public Text pointsText;

    public GameObject InitGame;
    private InitGame initGame;


    // Start is called before the first frame update
    void Start()
    {
        InitGame = GameObject.Find("InitGame");
        initGame = InitGame.GetComponent<InitGame>();
        gameOverManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = initGame.puntuacion.ToString("HighScore:" + "00");
    }

    //metodo para tener el canvas del gameover oculto (false) y que cuando en el script de la nave, se muera la nave, le llame y pase a verse (true).
    public void CallGameOver()
    {
            //GameOver.SetActive (true);
            Debug.Log ("GAMEOVER");
    }

    //funcion para que si pulso el boton PlayAgain se vuelva a poner la escena de la partida
    public void RestarButton()
    {
        SceneManager.LoadScene("Game");
    }

    //funcion para que si pulso el boton Exit me devuelva al main menu.
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
