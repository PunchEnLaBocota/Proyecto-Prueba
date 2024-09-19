using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Linterna : MonoBehaviour
{
    public GameObject myLight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))//Activar y descartivar el spotLight, como si fuera una linterna
        {
            myLight.SetActive(!myLight.activeInHierarchy);
        }
    }
}
