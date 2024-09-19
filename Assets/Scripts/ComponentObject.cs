using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Vamos a acceder al componente MeshRenderer del Gameobject para
/// cambiar su material
/// </summary>
public class ComponentObject : MonoBehaviour
{
    public Material mat; // Me guardo el material que quiero asignarle al gameObject
    MeshRenderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<MeshRenderer>().material = mat;
        
        rend = GetComponent<MeshRenderer>();
        rend.material = mat;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * 0 botón izquierdo
         * 1 botón derecho
         * 2 rueda
         */
        
        if (Input.GetMouseButtonDown(0))// Si pulso el botón izquiero del ráton
        {
           // Deshabilito el componente al que hace referencia la variable rend
            rend.enabled = false;
        }
    }
}
