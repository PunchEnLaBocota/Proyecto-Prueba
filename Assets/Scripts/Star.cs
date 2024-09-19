using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int turnSpeed;

    public GameObject gameManager;
    public GameManager gameManagerScript;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Acceder al GameManager para llamar a la función AddStar
            //gameManager.GetComponent<GameManager>().AddStar();//gameManager es una variable tipo Gameobject
            gameManagerScript.AddStar();//gameManager es una variable tipo GameManager

            Destroy(gameObject);
        }
    }
}
