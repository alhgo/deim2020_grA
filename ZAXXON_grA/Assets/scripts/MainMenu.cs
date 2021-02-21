using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //si pulso play me lleva a la escena de Game
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //si pulso custom me lleva a la escena custom
    public void Custom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //si pulso el Exit del main menu en vez de sacarme de la aplicacion me mande a consola Quit!.
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
