using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    
    [SerializeField] GameObject humo;
   
    public float speed = 2.5f;
    [SerializeField] GameObject[] vidasSprite;
    [SerializeField] Text speedText;
    int vidas = 3;
    [SerializeField] Text timeText;

    private string currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        MoverNave();

        
        

        
    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        //print(transform.position.x);
        float desplY = Input.GetAxis("Vertical");
        
        float desplX = Input.GetAxis("Horizontal");

        //Restringir movimiento horizontal
        if (PosX > 0 && PosX < 30)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }
        else if(PosX < 0 && desplX > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }
        else if (PosX > 30 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }

        //Restringir movimiento vertical
        if (PosY > 0 && PosY < 9)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }
        else if (PosY < 0 && desplY > 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }
        else if (PosY > 9 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }

transform.rotation = Quaternion.Euler(desplY * -10, 0 , desplX * -20);


    }


    void OnTriggerEnter (Collider other){

        if(other.gameObject.tag=="enemigo"){
           

         if(vidas>=1){

             vidas--;
             Destroy(vidasSprite[vidas]);
             print("vidas:"+vidas);
             if(vidas==1){
                 humo.SetActive(true);
             
             }
         }  
        else{
            
            //Time.timeScale=0f;
            print("GameOver");
        }

        }


   }
   







   
 /* void Texto(){
        float tiempo += Time.deltaTime;
        float segundos = (int) tiempo % 60;
        float minutos = (int) ((tiempo / 60) % 60);
timeText.Text="TIEMPO JUGANDO: " + minutos.ToString("00") +":" + segundos.ToString("00");

    }*/

}
