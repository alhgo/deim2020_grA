using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectorNaves : MonoBehaviour
{
    [SerializeField] private Button botonAnterior;
    [SerializeField]private Button botonSiguiente;
    private int naveActual;
    private int i;


    void start()
    {
    }
    
    private void Awake()
    {
        NaveSelector(0);
    }
    private void NaveSelector(int _index)
    {
        botonAnterior.interactable = (_index !=0);
        botonSiguiente.interactable = (_index != transform.childCount -1);
        for (int i = 0; i < transform.childCount; i++);
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }

    }

    public void CambioNave(int _change)
    {
        naveActual += _change;
        NaveSelector(naveActual);

    }

     public void ReturnMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
