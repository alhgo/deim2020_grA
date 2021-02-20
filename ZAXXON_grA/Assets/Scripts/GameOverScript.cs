using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    Spaceship spaceship;
    float score;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetFloat("guardarScore");
        //spaceship = gameObject.GetComponent<Spaceship>();
        print(score);
        scoreText.SetText("PUNTUACION:" + score); 
        
    }

    // Update is called once per frame
    void Update()
    {        
    }
}
