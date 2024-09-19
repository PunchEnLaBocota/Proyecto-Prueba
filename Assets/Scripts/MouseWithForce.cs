using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWithForce : MonoBehaviour
{
    //Creamos la clase Rigibody 
    Rigidbody rb;
     public float thrust;

    // Start is called before the first frame update
    void Start()
    {
        //Y aquí llamamos al componente Rigibody
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Addforce aplica fuerza a un Rigibody
        //Le damos fuerza en un eje concreto y le aplicamos la fuerza
        rb.AddForce(transform.up * thrust);
        //Le aplicamos la gravedad
        rb.useGravity = true;
    }
}
