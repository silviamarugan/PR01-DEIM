using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{


  
    int random = 0;
    [SerializeField] int numElegido = 57;

    // Start is called before the first frame update
    void Start()
    {

        while (random != numElegido) 
        {
            random = Random.Range(0, 100);
            print(random);
        }
      
        

        }

    // Update is called once per frame
    void Update()
    { 
      
    }
}
