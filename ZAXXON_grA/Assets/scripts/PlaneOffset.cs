using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneOffset : MonoBehaviour
{
    //Componente de tipo Renderer
    Renderer rend;
   
    float offset = 0;

   

    
    // Start is called before the first frame update
    void Start()
    {
        //Asignamos el componente Renderer
        rend = GetComponent<Renderer>();

       
    }

    // Update is called once per frame
    void Update()
    {
   
       
        offset = offset - 0.002f;
        //Vector de desplazamiento
        Vector2 despl = new Vector2(0, -offset);
        //Desplazamos la textura albedo y la normal
        rend.material.SetTextureOffset("_MainTex", despl);
        rend.material.SetTextureOffset("_BumpMap", despl);
    }
}
