using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Video;
using TMPro;

public class InGame : MonoBehaviour
{
    [SerializeField] AudioSource MusicPlayer;
    [SerializeField] AudioSource SFXPlayer;
    [SerializeField] VideoPlayer fondo;
    [SerializeField] GameObject PauseMenu;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject Opciones;
    [SerializeField] GameObject opcionesButton;
    [SerializeField] Animator transicion;
    [SerializeField] TextMeshProUGUI musicaVolume;
    [SerializeField] TextMeshProUGUI sfxVolume;
    static bool JuegoPausado;
    // Start is called before the first frame update
    void Start()
    {
        float musicaVolumen = PlayerPrefs.GetFloat("musicaVolumen");
        float sfxVolumen = PlayerPrefs.GetFloat("efectosVolumen");
        MusicPlayer.volume = musicaVolumen;
        SFXPlayer.volume = sfxVolumen;
        sfxVolume.SetText(Mathf.Round(SFXPlayer.volume*10).ToString());
        musicaVolume.SetText(Mathf.Round(MusicPlayer.volume*10).ToString());
    }

    // Update is called once per frame
    void Update()
    {   if(Input.GetButtonDown("Cancel") && PauseMenu.activeInHierarchy==false)
        {
            if(JuegoPausado)
            {
                Continuar();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void Continuar()
    {
        PauseMenu.SetActive(false);
        fondo.Play();
        Time.timeScale = 1f;
        JuegoPausado = false;
    }
    void Pausa()
    {
        PauseMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseButton);
        fondo.Pause();
        Time.timeScale = 0f;
        JuegoPausado = true;
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        StartCoroutine("TransicionMenu");  
    }
    public void OptionsMenu()
    {
        if(Opciones.activeInHierarchy == false)
        {
            Opciones.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(opcionesButton);
        }
        else
        {
            Opciones.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(pauseButton);
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
    IEnumerator TransicionMenu()
    {
        transicion.SetTrigger("Transition");
        Time.timeScale =1f;
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene("Menu");
    }
}
