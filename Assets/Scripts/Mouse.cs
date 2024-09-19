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
        Debug.Log("Has pulsado con el botón izquierdo del ratón.");
    }

    private void OnMouseUp()
    {
        Debug.Log("Has soltado con el botón izquierdo del ratón.");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Has pasado el ratón por encima del GameObject.");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Estas arrastando el ratón por encima del GameObject");
    }
}

