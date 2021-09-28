using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
    
{
 
   
    // Start is called before the first frame update
    void Start() {

        StartCoroutine("Reloj");
    }

    

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Reloj()
    {
        int sec = 0;
        int min = 0;
        int hrs = 0;
        string clock;

        for (int n = 0; ; n++)
        {

           
            sec++;
            if(sec > 59)
            {
                min++;
                sec = 0;

            }
            if (min > 59)
            {
                hrs++;
                min = 0;

            }
            if (hrs > 23)
            {
               
                hrs = 0;

            }

            clock = hrs.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
            print(clock);
            yield return new WaitForSeconds(1f);


        }
        
    }
}

