using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//Esto sirve para meter la libreria del TextMeshPro, para acceder a sus clases

public class GameManager : MonoBehaviour
{
    //Esto hace referencia al componente
    public TextMeshProUGUI textStar;

    int numStars;

    //Función o metodo público que va a ser llamado desde el script del Player cuando este obtenga
    //la estrella (onTrigger)
    public void AddStar()
    {
        numStars++;//Sumo1
        //Muestro por la interfaz: el ToString transforma el int en un String
        textStar.text = "" + numStars.ToString();
    }

   
}
