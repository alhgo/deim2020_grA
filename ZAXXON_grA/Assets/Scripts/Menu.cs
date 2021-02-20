using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject Inicial;
    [SerializeField] GameObject Opciones;
    [SerializeField] GameObject Creditos;
    [SerializeField] GameObject primerBotonInicio;
    [SerializeField] GameObject primerBotonOpciones;
    [SerializeField] GameObject botonCreditos;
    [SerializeField] Animator animator;
    [SerializeField] AudioSource MusicPlayer;
    [SerializeField] AudioSource SFXPlayer;
    [SerializeField] AudioClip MusicaCreditos;
    [SerializeField] AudioClip SFXMover;
    [SerializeField] AudioClip SFXClick;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") == 1 || Input.GetAxis("Horizontal") == 1)
        {
            SFXPlayer.PlayOneShot(SFXMover);
        }
        else if (Input.GetAxis("Enter") != 0)
        {
            SFXPlayer.PlayOneShot(SFXClick);
        }        
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Juego");
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void OptionsMenu()
    {
        if(Opciones.activeInHierarchy == false)
        {
            Opciones.SetActive(true);
            Inicial.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(primerBotonOpciones);
        }
        else
        {
            Opciones.SetActive(false);
            Inicial.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(primerBotonInicio);
        }
    }

    public void Credits()
    {
        if(Creditos.activeInHierarchy == false)
        {
            Creditos.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(botonCreditos);
            MusicPlayer.Stop();
            MusicPlayer.PlayOneShot(MusicaCreditos);
            animator.SetTrigger("Creditos");
        }
        else
        {
            Creditos.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(primerBotonInicio);
            MusicPlayer.Stop();
            MusicPlayer.Play();
        }            
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
