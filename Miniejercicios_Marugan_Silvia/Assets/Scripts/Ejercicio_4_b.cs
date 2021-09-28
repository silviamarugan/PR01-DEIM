using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4_b : MonoBehaviour
{
    [SerializeField] Vector3 playerPos = new Vector3(0f,0f,0f);
     float speed = 10f;
    

    [SerializeField] Transform playerPOS;
    [SerializeField] float DistanciaPLayer = 4.5f;
    [SerializeField] float AlturaCAM = 1.5f;

    Vector3 CamPOS;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPos;
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        //MOV CAMARA
        float newPosY = playerPOS.position.y + AlturaCAM;
        float newPosZ = playerPOS.position.z - DistanciaPLayer;
        transform.LookAt(playerPOS);
        print(playerPOS.position);
        transform.position = CamPOS = new Vector3(0f, newPosY, newPosZ);
        // FIN MOV CAMARA



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
        print(Input.GetAxis("Vertical"));
        //FIN MOV NAVE 
    }
   
}
