using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Clase que se va encargar de gestionar la fuerza de impulso de la bola
/// </summary>
public class Ball : MonoBehaviour
{
    //Fuerza
    public float force;
    //Dirección
    public Vector3 direction;
    //Creamos una variable de destrucción
    public float timeToDrestroy = 3;

    public Material mat;//material que voy a asignar al cubo

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDrestroy);
        
        //Buscamos en componente Rigibody que lleva Script Ball
        rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Si la etiqueta del gameObject con el que acaca de chocar la bola es Enemy
        if (collision.collider.CompareTag("Enemy"))
        {
            //Me estoy guardando en una variable local el Gameobject con el que estoy chocando
            GameObject cubeEnemy = collision.gameObject;

            //Nuestra variable cubeEnemy que nos hemos creado para llamar al GameObject (Que es el Enemy)
            //Accedemos a su componente Meshrenderer donde está el material y se lo cambiamos al colisionar
            cubeEnemy.GetComponent<MeshRenderer>().material = mat;
            
            //Destrute el gameobject con el que está chocando la bala
            //Destroy(collision.gameObject);
        }
    }

    //Sucede cuando un collider entra en otro collider, solo funciona si al Gameobject que marcas 
    //is trigger en el collider
    private void OnTriggerEnter(Collider other)
    {
        //Accedemos al otro collider que esta entrando en nuestro collider para mostrar su tag
        //Debug.Log(other.gameObject.tag);

        if (other.CompareTag("Enemy"))
        {
            GameObject cubeEnemy = other.gameObject;
            cubeEnemy.GetComponent<MeshRenderer>().material = mat;
        }
    }
}
