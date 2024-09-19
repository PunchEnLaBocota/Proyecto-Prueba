using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject ballPrefab;//Referencia al prefab de la bala (el que está en assets, (NUNCA METER
    //AQUÍ UN OBJETO DE LA ESCENA POR FAVOR)
    public Transform posBall;//Posición de la salida de la bala

    public float timeBetweenAttacks;//Tiempo entre ataques
    
    float timer;//Contador de tiempo

    
    // Start is called before the first frame update
    void Start()
    {
        //España.Andalucía.Malaga
        //GameObject.transform.position
        //Debug.Log("Posball: " + posBall.position);
    }

    // Update is called once per frame
    void Update()
    {
        //timer = timer + Time.deltaTime
        timer += Time.deltaTime;//Contador de tiempo : 0,1,2....
        //Debug.Log("Timer" + timer);

        //Si pulsamos el botón izquiero del ratón
        if (Input.GetMouseButtonDown(0) && timer >= timeBetweenAttacks)
        {
            //Llamaos al CreateBall creamos la bola
            CreateBall();
        }
    }

    void CreateBall()
    {
        timer = 0;//Reseteamos el contador de tiempo para que tarde un tiempo en volver a atacar
        //Estoy creando clones de un prefab y me estoy guardando el clone en una
        //variable local(cloneBallPrefab)
        GameObject cloneballPrefab =  Instantiate(ballPrefab, posBall.position, posBall.rotation); 

        //Le estoy dando dirección a la bala y le digo que pille la del eje Z del Gameobject que lleva
        //este script, que en este caso lo lleva el player
        cloneballPrefab.GetComponent<Ball>().direction = transform.forward;
    }
}
