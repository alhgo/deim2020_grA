using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIMenu : MonoBehaviour
{

    public GameObject UI;
    private UI ui;
    // Start is called before the first frame update
    void Start()
    {
        ui = UI.GetComponent<UI>();
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void PulsarBotonPlay()
    {

        SceneManager.LoadScene(1);
    }

    public void PulsarBotonQUIT()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
