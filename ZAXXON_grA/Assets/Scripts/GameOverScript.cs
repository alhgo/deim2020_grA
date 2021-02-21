using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] AudioSource MusicPlayer;
    [SerializeField] AudioSource SFXPlayer;
    float score; 
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1f;
        score = PlayerPrefs.GetFloat("guardarScore");
        //spaceship = gameObject.GetComponent<Spaceship>();
        print(score);
        scoreText.SetText("PUNTUACION:" + score); 
        float musicaVolumen = PlayerPrefs.GetFloat("musicaVolumen");
        float sfxVolumen = PlayerPrefs.GetFloat("efectosVolumen");
        MusicPlayer.volume = musicaVolumen;
        SFXPlayer.volume = sfxVolumen;        
    }
}
