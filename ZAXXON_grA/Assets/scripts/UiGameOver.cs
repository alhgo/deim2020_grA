using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiGameOver : MonoBehaviour
{

    public GameObject InitGame;
    private InitGame initGame;
    public GameObject UI;
    private UI ui;


    [SerializeField] Text displayPuntuacionFinal;

    // Start is called before the first frame update
    void Start()
    {
        
        initGame = InitGame.GetComponent<InitGame>();
        ui = UI.GetComponent<UI>();
    }

    // Update is called once per frame
    void Update()
    {
        displayPuntuacionFinal.text = ui.puntuacionfinal.ToString("Tu   puntuacion   es  : " + "00");
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
}
