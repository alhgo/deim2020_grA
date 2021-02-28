using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static bool GameIspaused = false;
    public GameObject pauseMenu; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        GameIspaused = true;
    }
    void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        GameIspaused = false;
    }


    void Botondepausa()
    {
        if (Input.GetButtonDown("Stop"))
        {
            if (GameIspaused)
            {
                ResumeGame();
            } else
            {
                PauseGame()
            }
        }
    }
}
