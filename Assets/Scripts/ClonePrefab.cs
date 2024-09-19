using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePrefab : MonoBehaviour
{
    //Aqu� indico el prefab que quiero clonar
    public GameObject _object;
    //Aqu� indico la posici�n en la que aparezcan los clones de la prefab
    public Transform transformChild;

    public float thrust;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos el boton izquierdo del raton llamamos al metodo CreateObject para clonar nuestro prefab
        if (Input.GetMouseButtonDown(0))
        {
            //CreateObject();
            //LLama al m�todo CreateObject transcurridos 5 segundos
            //Invoke("CreateObject", 5);
            //Llamamos al m�todo CreateObject la primera vez en 1 segundo y luego cada 5 segundos
            InvokeRepeating("CreateObject", 1, 3);

        }
    }

    void CreateObject() //Creamos un metodo para clonar nuestro prefab
    {
        //Creo la variable cloneball donde almacenamos nuestros clones(Los poops)
        //Y Elegimos el objecto que clonamos(poop), m�s su posici�n, mas su rotaci�n
        GameObject cloneBall = Instantiate(_object, transformChild.position, transformChild.rotation);
       
        //Aplicamos el rigibody a nuestros clones poops, para despu�s aplicarles la fuerza
        Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();
        
        //Destruyeme todos los cones del prefab (Los poops) pasados 5 segundos
        Destroy(cloneBall, 5);
       
        //Aplicamos fuerza en el Y hacia arriba
        rbBall.AddForce(Vector3.up * 100);
        
        //Aplicamos fuerza en el eje Z para atr�s
        rbBall.AddForce(-transform.forward * thrust);
        //Y as� conseuiremos que salgan como un proyectil

    }
}
