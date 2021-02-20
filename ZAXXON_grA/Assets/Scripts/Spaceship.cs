using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class Spaceship : MonoBehaviour
{
    public float speed;
    //[SerializeField] Text Speed;
    [SerializeField] Text TimePlayed;
    //[SerializeField] Text Distance;
    //public GameObject[] ObjetoEnemigo;
    [SerializeField] Collider naveCollider;
    [SerializeField] MeshRenderer naveMesh;
    [SerializeField] GameObject escudoHUD;
    [SerializeField] GameObject energiaHUD;
    [SerializeField] AudioSource escudoSound;
    [SerializeField] VideoPlayer fondo;
    [SerializeField] AudioClip escudoSFX;
    [SerializeField] TextMeshProUGUI vidasText;
    [SerializeField] TextMeshProUGUI tiempoText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI energiaText;
    //private Enemigo enemigo;
    float tiempo;
    float minutos;
    public float segundos;
    float score;
    int vidas;
    public float guardarScore;

    
    // Start is called before the first frame update
    void Start()
    {
        speed = 12.5f;
        vidas = 3;
        tiempo = 0;
        minutos = 0;
    }
    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();
        //Método UI tiempo y velocidad
        UIMarcadores();

    }
    void MoverNave()
    {
        //print(transform.position.x);
        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        //restringir movimiento en el eje X
        if (posX < 12 && posX > -12 || posX < -12 && desplX > 0 || posX > 12 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }

        //restringir movimiento en el eje Y
        if (posY < 9 && posY > 1.5 || posY < 1.5 && desplY > 0 || posY > 9 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }

        transform.rotation = Quaternion.Euler(desplY * -20, 0, desplX * -20);
    }
    void UIMarcadores(){ 
        tiempo += Time.deltaTime;
        segundos = (int) tiempo % 60;
        minutos = (int) ((tiempo / 60) % 60);
        if(vidas >= 0)
        {
            score += (int) tiempo * (vidas+1);
        }   
        
        vidasText.SetText("VIDAS: " + vidas.ToString());
        tiempoText.SetText("TIEMPO JUGANDO: " + minutos.ToString("00") +":" + segundos.ToString("00"));
        scoreText.SetText("PUNTUACION: " +score);
        
    }
    void OnTriggerEnter(Collider enemigo)
    {
        if(enemigo.gameObject.tag == "Obstaculo")
        {
            if(vidas >= 1)
            {
                vidas--;
                print("TE CHOCASTE, VIDAS: " +vidas);
                StartCoroutine(Choque());
            }
            else if(vidas == 0)
            {
                PlayerPrefs.SetFloat("guardarScore", score);
                StartCoroutine(Muerte());
            }
        }
        
    }
    IEnumerator Choque()
    {
        naveCollider.enabled = false;
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(0.4f);
        for(int n = 3; n>0; n--)
        {
            Time.timeScale = 1f;
            escudoHUD.SetActive(false);
            yield return new WaitForSeconds(0.07f);
            escudoHUD.SetActive(true);
            escudoSound.PlayOneShot(escudoSFX);
            yield return new WaitForSeconds(0.07f);
        }
        energiaHUD.SetActive(true);
        for(int n = 100; n>=0; n--)
        {
            energiaText.SetText("ENERGIA RESTANTE: "+ n + "%");
            yield return new WaitForSeconds(0.03f);
        }
        yield return new WaitForSeconds(0.1f);
        energiaHUD.SetActive(false);
        for(int n = 3; n>0; n--)
        {
            escudoHUD.SetActive(true);
            yield return new WaitForSeconds(0.071f);
            escudoHUD.SetActive(false);
            escudoSound.PlayOneShot(escudoSFX);
            yield return new WaitForSeconds(0.07f);
        }
        naveCollider.enabled = true;
    }
    IEnumerator Muerte()
    {
        Time.timeScale = 0.3f;
        fondo.Pause();
        print("Has muerto");
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("GameOver");
        Time.timeScale = 0f;
    }
}
