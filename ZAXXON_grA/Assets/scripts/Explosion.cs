using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject expp;
    //Start is called before the first frame update



    private void OnCollisionEnter(Collision other)
    {
        GameObject exp = Instantiate(expp, transform.position, transform.rotation);
        Destroy(expp, 3);
        Destroy(gameObject);
    }
}
