using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
   /* //El array se crea con []
    [SerializeField] int[] myVar;
    //Se crea un array String ya con 5 elementos
    [SerializeField] string[] myString = new string[5];
    //Array
    GameObject[] numEnemigos;*/
    [SerializeField] GameObject[] objetos;
    //Para poner en un sitio a un prefab.
    Vector3 initPosWhite = new Vector3(-21, 0, 21);
    //Peón
    Vector3 initPosPawnWhite = new Vector3(-21, 1, 15);
    Vector3 initPosPawnBlack = new Vector3(-21, 1, -27);
    Vector3 initPosBlack=new Vector3(-21,0-21);
    
    void Start()
    {
        /*//Meter prefab columna. Y entre los corchetes se meten los números y aparece en pantalla el prefab.
        //Números aleatorios entre 0 y x. Aparecen de forma aleatoria los prefabs.
        int r = Random.Range(0, objetos.Length);*/
        //Aparece en el sitio que hemos puesto arriba. Euler es para girar. Identity es que no gira. El bucle es para crear una fila. 
        for(int n = 0; n < 8; n++)
        {
            Instantiate(objetos[n], initPosWhite, Quaternion.Euler(-90, 90, 0));
            initPosWhite = initPosWhite + new Vector3(6, 0, 0);
        }
        //Peon blanco
        for(int p = 0; p < 8; p++)
        {
            Instantiate(objetos[8], initPosPawnWhite, Quaternion.Euler(-90, 90, 0));
            initPosPawnWhite = initPosWhite + new Vector3(6, 0, 0);
        }
        //Peon negro
        for (int p = 0; p < 17; p++)
        {
            Instantiate(objetos[17], initPosPawnBlack, Quaternion.Euler(-90, 90, 0));
            initPosPawnBlack = initPosBlack + new Vector3(6, 0, 0);
        }
        for (int n = 9; n < 17; n++)
        {
            Instantiate(objetos[n], initPosBlack, Quaternion.Euler(-90, -90, 0));
            initPosBlack = initPosBlack + new Vector3(6, 0, 0);
        }


        /* //Mi array(numEnemigos) nos va a decir cuántos enemigos hay.
         numEnemigos = GameObject.FindGameObjectsWithTag("Enemy");
         print(numEnemigos.Length);

         //Bucle. N es menor que 5 porque hay 0,1,2,3,4. En el lado derecho en My String sale cuando le das al play. Bucle que se repite solo 5 veces (n<5) 
         //myString.Lenght Se accede a sus atributos. Se rellenan todos los elementos. Si pones 6 elementos, se rellena hasta el 6.
         for(int n=0;n< numEnemigos.Length; n++)
         {
             //Las coordenadas de los enemigos
             print("Este es el enemigo" + numEnemigos[n].transform.position);
             /*
             myString[n] = "Este es el elemento" + n;*/
    }
        /* //En la parte derecha al darle al play, te aparece directamente el texto en My String.
         myString[3] = "Mi cuarto elemento";
         //Suma dos elementos. El triángulo significa un array, lo abres y te salen todos los elementos.
         print(myVar[2]+myVar[3]);
         */
    }



