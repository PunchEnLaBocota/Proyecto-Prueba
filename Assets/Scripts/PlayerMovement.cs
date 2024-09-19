using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    public int turnSpeed;

    float h,
          v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Todos los Input van el y  la actualización de variables van en el Update
    //Porque son cosas que deben estar todo el rato actualizandose

    void Update()
    {
        InputPlayer();
        Movement();
        Rotate();
    }

    void InputPlayer()
    {

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    void Movement()
    {
        //Si no multiplacaramos por Time.deltatime se moveria Metros*Frame
       //Al multiplicarlo por Time.deltatime conseguimso que sea Metros*Segundos
        transform.Translate(Vector3.forward * speed * v * Time.deltaTime);
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * turnSpeed * h * Time.deltaTime);
    }

    //Todo movimiento de fisicas va en el FixedUpdate por tema de rendimieno
}
