using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Con Control+shift+M para ver todos los metodos que puedes usar

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() //Debe tener un mesh para que funcione este metodo
    {
        Debug.Log("Has pulsado con el bot�n izquierdo del rat�n.");
    }

    private void OnMouseUp()
    {
        Debug.Log("Has soltado con el bot�n izquierdo del rat�n.");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Has pasado el rat�n por encima del GameObject.");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Estas arrastando el rat�n por encima del GameObject");
    }
}

