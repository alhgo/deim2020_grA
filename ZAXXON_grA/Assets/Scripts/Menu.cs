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
    [SerializeField] Animator transicion;
    [SerializeField] AudioSource MusicPlayer;
    [SerializeField] AudioSource SFXPlayer;
    [SerializeField] AudioClip MusicaCreditos;
    [SerializeField] AudioClip SFXMover;
    [SerializeField] AudioClip SFXClick;
    [SerializeField] TextMeshProUGUI musicaVolume;
    [SerializeField] TextMeshProUGUI sfxVolume;

    public void PlayGame()
    {
        Time.timeScale = 1f;
        StartCoroutine("Transicion");
    }

    public void BackToMenu()
    {        
        StartCoroutine("TransicionMenu");        
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

    public void SubirMusica()
    {
        if(MusicPlayer.volume <1)
        {
            MusicPlayer.volume = MusicPlayer.volume + 0.1f;
            float volumen = Mathf.Round(MusicPlayer.volume*10);
            PlayerPrefs.SetFloat("musicaVolumen", MusicPlayer.volume);
            musicaVolume.SetText(volumen.ToString());
        }        
    }
    public void BajarMusica()
    {
        if(MusicPlayer.volume > 0)
        {
            MusicPlayer.volume = MusicPlayer.volume - 0.1f;
            float volumen = Mathf.Round(MusicPlayer.volume*10);
            PlayerPrefs.SetFloat("musicaVolumen", MusicPlayer.volume);
            musicaVolume.SetText(volumen.ToString());
        }        
    }
    public void SubirEfectos()
    {
        if(SFXPlayer.volume <1)
        {
            SFXPlayer.volume = SFXPlayer.volume + 0.1f;
            float volumen =  Mathf.Round(SFXPlayer.volume*10);
            PlayerPrefs.SetFloat("efectosVolumen", SFXPlayer.volume);
            sfxVolume.SetText(volumen.ToString());
        }        
    }
    public void BajarEfectos()
    {
        if(SFXPlayer.volume > 0)
        {
            SFXPlayer.volume = SFXPlayer.volume - 0.1f;
            float volumen = Mathf.Round(SFXPlayer.volume*10);
            PlayerPrefs.SetFloat("efectosVolumen", SFXPlayer.volume);
            sfxVolume.SetText(volumen.ToString());
        }        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator Transicion()
    {
        transicion.SetTrigger("Transition");
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene("Juego");
    }
    IEnumerator TransicionMenu()
    {
        transicion.SetTrigger("Transition");        
        yield return new WaitForSeconds(1.3f);
        Time.timeScale =1f;
        SceneManager.LoadScene("Menu");
    }
}
