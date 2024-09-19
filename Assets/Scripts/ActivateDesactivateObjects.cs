using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ActivateDesactivateObjects : MonoBehaviour
{
    public GameObject myCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))// Si pulso la tecla P 
        {
            gameObject.SetActive(false);// Desactivo el GameObject que tenga este script
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            // ---> El signo ! puesto delante de una variable booleana le cambia el signo a la misma, es decir
            // si vale true pasa a valer false y viceversa
            // ---> activateInHierachy me devuelve un true si el objeto está activado en herarquía y un false
            // si está desactivado 
            myCube.SetActive(!myCube.activeInHierarchy);// Desactivo el GameObject al que hago referencia a la variable myCube
        }
    }
}
