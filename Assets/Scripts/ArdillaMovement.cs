using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArdillaMovement : MonoBehaviour
{
    public int speed,
               turnSpeed;

    float h,
          v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        MovementPlayer();
    }
    void InputPlayer()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    void MovementPlayer()
    {
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime);
    }
}
