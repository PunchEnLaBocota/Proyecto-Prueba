using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    public int turnSpeed;

    private void Awake() // El Awake se ejecuta antes que el start
    {
        //Debug.Log("Awake");
    }

    // Start is called before the first frame update 
    void Start()
    {
        //Debug.Log("Start");
                          //España.Andalucía.Málaga
        //float xPosition = transform.position.x;
        //Te muestra la posición del x
        //Debug.Log("Posición en X es: " + xPosition);
        //Te muestra la posición del objeto 
        //Debug.Log("Posición es: " + transform.position);
    }

    // Update is called once per frame, el update no es constante
    void Update()
    {
        //Movimiento de un objeto = dirección + velocidad
        /*
         * Vector3.forward = (0,0,1) -> Vector Unitario, Modúlo = 1, Es un vector que solo me da la dirección
         * Vector3.right = (1,0,0) -> Eje X
         * Vector.up = (0,1,0) -> Eje Y
         */
        //Estamos haciendo que un objeto en una dirección se mueva a metros por segundo.
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.Translate(Vector3.up * speed * Time.deltaTime);
        //transform.Translate(Vector3.right * speed * Time.deltaTime);

        //Estamos haciendo que un objeto rote en una dirreción grados por segundo
        //transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

        //Movement();//Llamada a la función
        //MovementGetKey2();
        MovementGetAxis();


        //Debug.Log("Update: " + Time.deltaTime);
    }

    void MovementGetAxis()
    {
        float v = Input.GetAxis("Vertical");// Mapeo teclas WS, si pulso W (v = 1), si pulso S (v = -1)
                                            //Si no pulso nada (v = 0)
        float t = Input.GetAxis("Horizontal");// Mapeo de teclas AD

        Debug.Log("Valor axis vertical; " + v);
        Debug.Log("Valor axis horizontal; " + t);
        
        transform.Translate(Vector3.forward * speed * v * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * t * Time.deltaTime);
    }

    
    void MovementGetKey() //Ejemplo de movimiento basico
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Acabo de pulsar la tecla W");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            Debug.Log("Estoy pulsando la tecla W");
           
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("Acabo de liberar la tecla W");
        }
    }

    void MovementGetKey2() //Ejemplo de movimiento 2
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        }
       
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);

        }
    }
    
    void FixedUpdate() // Se ejecuta de ejecuta cada x segundos(Normalente 0.02 segundos), es constante no como
                       // el update. Se usa para cáculo de movimiento por físicas                 
    {
        //Debug.Log("FixedUpdate" + Time.deltaTime);
    }
}
