using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePrefab : MonoBehaviour
{
    //Aquí indico el prefab que quiero clonar
    public GameObject _object;
    //Aquí indico la posición en la que aparezcan los clones de la prefab
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
            //LLama al método CreateObject transcurridos 5 segundos
            //Invoke("CreateObject", 5);
            //Llamamos al método CreateObject la primera vez en 1 segundo y luego cada 5 segundos
            InvokeRepeating("CreateObject", 1, 3);

        }
    }

    void CreateObject() //Creamos un metodo para clonar nuestro prefab
    {
        //Creo la variable cloneball donde almacenamos nuestros clones(Los poops)
        //Y Elegimos el objecto que clonamos(poop), más su posición, mas su rotación
        GameObject cloneBall = Instantiate(_object, transformChild.position, transformChild.rotation);
       
        //Aplicamos el rigibody a nuestros clones poops, para después aplicarles la fuerza
        Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();
        
        //Destruyeme todos los cones del prefab (Los poops) pasados 5 segundos
        Destroy(cloneBall, 5);
       
        //Aplicamos fuerza en el Y hacia arriba
        rbBall.AddForce(Vector3.up * 100);
        
        //Aplicamos fuerza en el eje Z para atrás
        rbBall.AddForce(-transform.forward * thrust);
        //Y así conseuiremos que salgan como un proyectil

    }
}
