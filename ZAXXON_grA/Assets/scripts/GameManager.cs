using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public Timer timer;

    public Sphere sphere;
    
    bool gameHasEnded = false;

     public GameObject gameOverUI;

     public GameObject timerGameOverUI;

    
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Función para que si muere la nave salte la pantalla de GameOver.
    public void GameOver()
    {
        if (sphere.life < 1)
        {
            gameOverUI.SetActive(true);
        }

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
        }
    }
}
