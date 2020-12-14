using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
   //Es una variable con la que le vamos a decir a nuestro metodo IniciarColumnas que tenga la  distancia entre ellas
    [SerializeField] float distobstacle;
    
        
    // Start is called before the first frame update
    void Start()
    {
       //Startcoroutine es lo que tenemos que poner cuando queremos que se inicie una corrutina abres parentesis y entre comillas pones el nombre que le has puesto
        StartCoroutine("ColumnCorrutine");
        InicioColumnas();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CrearColumna();
        }

    }

    void CrearColumna()
    {
        //Crear una variable para que genere un numero aleatorio entre los dos rangos que le asigno
        float posRandom = Random.Range(0f, 30f);
        //Creas un nuevo vector que va a ser el destino donde se genere la columna, el posramdom al principio debido a que queremos que se genere en el eje x en el centro seria el eje y , z en ultimo lugar
        Vector3 DestPos = new Vector3(posRandom, 0, 0);
       //Este vector coge la posicion de referencia y le añade ese vector aleatorio
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }
    //corrutina es un metodo/funcion que se puede realizar sin parar el codigo
    IEnumerator ColumnCorrutine()
    {
        //for(puntodeinicio,condicion,accionfinal) este bucle nos sirve para crear la columna cada x tiempo
        for (int n=0; ; n++ )
        {
            //para ver las columnas que estoy generando
            print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn); esto solo es necesario si me pide que lo cree en 0,0,0
            //aqui como queremos que se genere en la posicion ramdom asignamos el metodo que hemos creado para que haga esto
            CrearColumna();
          //Dentro del for hacemos un yield return que basicamente es decirle al for que pare antes de volver hacerse
            yield return new WaitForSeconds(1);
        }
    }

    void InicioColumnas(){




           distobstacle = 10f;
        //creamos un bucle que dependa del numero de columnas que quiera crear
        for (int n = 1; n < 20; n++) ;

            /*
        {
           //hacemos lo mismo que en crear columna pero ahora en eje z le metemos la variable que hemos creado de distobstacle
            float randomX = Random.Range(0f, -30f);
            NewPos = new Vector3(randomX, 0, n * distobstacle);
            Vector3 finalPos = RefPos.position - NewPos;
            Instantiate(MyColumn, finalPos, Quaternion.identity);
        }
            */
    }



}
