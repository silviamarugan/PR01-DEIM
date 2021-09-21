using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{


    int random;
    int num;
  
    [SerializeField] int numElegido = 7;

    // Start is called before the first frame update
    void Start()
    {
        //bucle con while
        //num = 0;

       // while (random != numElegido)
        {
          //  random = Random.Range(0, 15);
         //   print(random);
        }

        { 

         //fin bucle while




        //bucle con for
        for (int random2 = 0; random2 != numElegido; random2 = Random.Range(1,15))
            {
                print("Aleatorio FOR es igual a " + random2);
                if (random2 < 5)
                {
                    print("Aleatorio FOR es menor que 5");


                }
                else if (random2 > 5)
                {

                    print("Aleatorio FOR es mayor que 5");
                }



            }
        //fin bucle for
        }
      






    }

    // Update is called once per frame
    void Update()
    { 
      
    }
}
