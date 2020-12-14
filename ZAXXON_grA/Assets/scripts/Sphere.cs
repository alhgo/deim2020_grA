using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    //Declaramos la velocidad de la nave fuera
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        //aqui asignamos la velocidad para que siempre empieze con esta
        speed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();

    }

    void MoverNave()
    {
        //para comprobar el desplazamiento en x
        print(transform.position.x);
       //aqui asignamos el desplazamiento a los controles del mando/teclado vertical
        float desplY = Input.GetAxis("Vertical");
       //Esto es para mover la nave de arriba 
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        //aqui asignamos el desplazamiento en horizontal
        float desplX = Input.GetAxis("Horizontal");
        //mover en el eje horizontal     
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);

        //creamos una variable que compruebe la posicion del objeto que esta asignado al script
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        //Se mueve siempre que este en las posiciones marcadas en este caso -11 y -3
        if (PosX > -11 && PosX < -3)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        //Esto dice: Si te pasas de -11 pero esta intentando volver dejalo moverse
        else if (PosX < -11 && desplX > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
       //Esto dice: Si te pasas de -3 pero esta intentando volver dejalo moverse
        else if (PosX > -3 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

       /*Es el metodo resumido del movimiento restringido
        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        //restringir movimiento en el eje X
        if (posX < 14 && posX > -14 || posX < -14 && desplX > 0 ||  posX > 14 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //restringir movimiento en el eje Y
        if (posY < 10 && posY > 1 || posY < 1 && desplY > 0 || posY > 10 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        */

        /*
        int suma1 = 19;
        int suma2 = 11;
        int result;
        
        //siemrpe que llame a sumitas me va a dar el resultado de 19+11
        int Sumitas(){
            result= suma1 + suma2;
            returm = result;
        //para hacer una funcion que cada vez que la llame sume los numero que yo le pida
        
        int Sumas(int a , int b){
            result= a+b;
            return = result;
            //en el metodo Start ponemos la funcion Sumas(y aqui ponemos los enteros que quiere que sume)
            Sumas(2,4)
            Sumas(3,6)

        }
    */
        }

    // PARA USERI INTERFACE
    //añadir arriba del todo using UnityEngine.UI;
    //un serializedfield de tipo de texto
    //Lo asignas en unity
    //Creas un método en el que se va a cambiar el texto si a lo largo del juego es un texto que va cambiando como un contador se metera en el update en el caso contrario en el star
    // DISTANCIA 
    // DISTANCIA.text = "DISTANCIA"




    }

