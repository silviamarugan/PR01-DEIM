using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4_b : MonoBehaviour
{
     Vector3 playerPos = new Vector3(0f,0.40f,-23f);
     float speed = 10f;
    

  


    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPos;
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        



        //DISPARO
        if (Input.GetKey(KeyCode.Space))
        {
            print("disparo");
        }
        //FIN DISPARO


        //MOV NAVE
        transform.Translate(Vector3.right  * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
        transform.Translate(Vector3.up  * Time.deltaTime * Input.GetAxis("Vertical") * speed);
        transform.Translate(Vector3.forward * Time.deltaTime);
        print(Input.GetAxis("Horizontal"));
      
        //FIN MOV NAVE 
    }
   
}
