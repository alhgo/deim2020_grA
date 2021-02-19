using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroidesAleatorios : MonoBehaviour
{

    [SerializeField] GameObject[] asteroides;
    private int randomizadorAsteroides;
    public GameObject InitGame;
    private InitGame initGame;

    [SerializeField] Transform RefPos;

    // Start is called before the first frame update
    void Start()
    {
        initGame = InitGame.GetComponent<InitGame>();
        StartCoroutine("AsteroideCorrutine");

    }

    // Update is called once per frame
    void Update()
    {
         
    }
    


    void CrearAsteroide()
    {
       
        float posRandomX = Random.Range(0, 60);
        float posRandomY = Random.Range(-60, 60);
        randomizadorAsteroides = Random.Range(0,asteroides.Length);
        Vector3 posRandom = new Vector3 (posRandomX,posRandomY,0);
            
        Vector3 NewPos = RefPos.position + posRandom;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(asteroides[randomizadorAsteroides], NewPos, Quaternion.identity);
    }


    IEnumerator AsteroideCorrutine()
    {
        for(int n = 0; ; n++)
        {
            CrearAsteroide();
            yield return new WaitForSeconds(0.1f);
        }
        
    }
}
