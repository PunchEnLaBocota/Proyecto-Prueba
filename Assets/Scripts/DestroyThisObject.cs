using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisObject : MonoBehaviour
{
    //Creamos una variable GameObject
    public GameObject _object;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos el boton izquierdo del raton llamamos al metodo de destrucion del Gameobject que hemos
        //del Gameobject que hemos elegido
        if (Input.GetMouseButtonDown(0))
        {
            DestroyObject();
        }
    }
    
    void DestroyObject() //Creamos el metodo destrucción del Gameobject que hemos elegido
                         //y decidimos que se destruya en 5 segundos
    {
        Destroy(_object, 5);
    }
}
