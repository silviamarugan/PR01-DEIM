using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{


    int num;
  

    // Start is called before the first frame update
    void Start()
    {
      


    }

    // Update is called once per frame
    void Update()
    {
        print(num = 0);
        num++;
        if (num < 1000)
        {
            print(num);
        }
        else if (num == 1000)
        {
            print("Fin del contador");
        }
      
    }
}
