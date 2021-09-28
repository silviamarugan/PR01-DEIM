using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3_a : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Saludar ("Hola" + nombre);
        print("Hola" + nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   [SerializeField] string nombre;
    void Saludar(string nombre) {

        

    }
}
