using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed = 8f;
    [SerializeField] GameObject Nave;
    [SerializeField] GameObject Canvasscript;
    [SerializeField] Renderer Navemesh;
    [SerializeField] GameObject Explosion;
    [SerializeField] GameObject SpriteUp;
    [SerializeField] GameObject SpriteDown;
    [SerializeField] GameObject SpriteRight;
    [SerializeField] GameObject SpriteLeft;
    public GameObject pauseMenu;
    public float tiempodejuego;
    public bool crearmeteoritos = true;
    public GameObject GOCanvas;
    public GameObject Llamitas;
    public AudioClip sonidojet;
    AudioSource audioSourceJet;
    public AudioClip explosion;
    AudioSource audioSourceExp;
    bool EstaPausa = false;
    bool EstoyMuerto = false;
    Musiccript musiccript;
    [SerializeField] GameObject MusicaNivel;
    


    // Start is called before the first frame update
    void Start()
    {
        tiempodejuego = 0.00f;
        StartCoroutine("AumentoVelocidad");
        StartCoroutine("AumentoPitch");
        StartCoroutine("Tiempojuego");
        audioSourceJet = GetComponent<AudioSource>();
        audioSourceJet.clip = sonidojet;
        audioSourceJet.volume = 0.1f;
        audioSourceJet.loop = true;
        audioSourceJet.Play();


    }

    // Update is called once per frame
    void Update()
    {
		MoverNave();
        BotondePause();
        AyudaLimites();
        if (speed == 16f) { StopCoroutine("AumentoVelocidad"); }
        
    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        if (PosX > -13 && PosX < 13 || PosX < -13 && desplX > 0 || PosX > 13 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        if (PosY > -13 && PosY < 13 || PosY < -13 && desplY > 0 || PosY > 13 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }

      }

    void AyudaLimites()
    {
        if (EstoyMuerto == false)
        {
            float PosX = transform.position.x;
            float PosY = transform.position.y;
            if (PosY < -11) { SpriteUp.SetActive(true); } else { SpriteUp.SetActive(false); }
            if (PosY > 11) { SpriteDown.SetActive(true); } else { SpriteDown.SetActive(false); }
            if (PosX < -11) { SpriteRight.SetActive(true); } else { SpriteRight.SetActive(false); }
            if (PosX > 11) { SpriteLeft.SetActive(true); } else { SpriteLeft.SetActive(false); }
        }

    }

    public void BotondePause()
    {
        if (Input.GetButtonDown("Pause")) {
            if (EstoyMuerto == false)
            { 
            if (EstaPausa == false)
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
                EstaPausa = true;
                audioSourceJet = GetComponent<AudioSource>();
                audioSourceJet.Pause();

            }
            else
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;
                EstaPausa = false;
                audioSourceJet = GetComponent<AudioSource>();
                audioSourceJet.UnPause();
            }
            }
        }
    }

    IEnumerator AumentoVelocidad()
    {
        for (int n = 0; ; n++)
        {
            
            yield return new WaitForSeconds(5f);
            speed = speed + 1;
        }
    }

    IEnumerator AumentoPitch()
    {
        for (int n=0; ; n++)
        {
            audioSourceJet = GetComponent<AudioSource>();
            audioSourceJet.pitch = audioSourceJet.pitch + 0.1f;
            yield return new WaitForSeconds(3f);
            if(audioSourceJet.pitch == 2.9f) { StopCoroutine("AumentoPitch"); }
        }

    }


    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Expljuego");
    }

    IEnumerator Expljuego()
    {
        for (int n = 0; n <= 3 ; n++)
        {
            if (n == 0) {
                EstoyMuerto = true;
                Instantiate(Explosion, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                crearmeteoritos = false;
                Llamitas.SetActive(false);
                Nave.GetComponent<Renderer>();
                Navemesh.enabled = false;
                audioSourceJet = GetComponent<AudioSource>();
                audioSourceJet.Stop();
                audioSourceExp = GetComponent<AudioSource>();
                audioSourceExp.PlayOneShot(explosion, 1F);
                StopCoroutine("Boton de Pause");

            }
            else if (n < 3) 
            { 
                StopCoroutine("AumentoVelocidad");
                StopCoroutine("Tiempojuego");
            }
            else
            {
                GOCanvas.SetActive(true);
                Time.timeScale = 0f;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator Tiempojuego()
    {
        for (int n = 0; ; n++)
        {
            tiempodejuego = tiempodejuego + 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
    }

}
