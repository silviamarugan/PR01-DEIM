using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour

   
{
    [SerializeField] float num1 = 2.5f;
    [SerializeField] int num2 = 1;

    public string nombre = " Silvia ";
    bool correcto;
    private string mensaje;
    private float resultado;
  
    // Start is called before the first frame update
    void Start()
    {
        

        mensaje = ("Hola" + nombre + ":)" );
        resultado = (num1 * num2);
        print(resultado);
        print(mensaje);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
