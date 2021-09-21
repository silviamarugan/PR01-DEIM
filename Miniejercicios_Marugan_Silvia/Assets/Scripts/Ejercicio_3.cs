using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
    
{

    int sec = 0;
    bool relojEncendido = false;
    // Start is called before the first frame update
    void Start() {
        StartCoroutine("Reloj");
        IEnumerator Reloj () { }

    }

    
  



    // Update is called once per frame
    void Update()
    {

        if (relojEncendido)
        {

            StopCoroutine("Reloj");
            relojEncendido = false;

       
        }
        if (Input.GetKeyDown("Space"))
        {

            StartCoroutine("Reloj");
        }
    }
   
}
