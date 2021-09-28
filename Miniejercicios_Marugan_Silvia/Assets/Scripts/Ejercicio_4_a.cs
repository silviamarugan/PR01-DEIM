using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            StartCoroutine("Contador");
           
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {

            StopCoroutine("Contador");
        }


    }
    IEnumerator Contador()
    {
       for (int n = 0; ; n++)
        {

            
            yield return new WaitForSeconds(1f) ;


        }
    }
}
