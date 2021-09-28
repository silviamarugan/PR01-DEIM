using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_b : MonoBehaviour
{
    [SerializeField] float n1;
    [SerializeField] float n2;
    [SerializeField] string op;
    // Start is called before the first frame update
    void Start()
    {
        Calcular(n1, n2, op);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Calcular(float n1, float n2, string op)
    {
        float resultado = 0f;


        if (op == "multiplicar")

        {
            resultado = n1 * n2;
        }


        else if (op == "dividir")

        {
            resultado = n1 / n2;
        }


        else if (op == "restar")



        {
            resultado = n1 - n2;
        }


        else 

        {
            resultado = n1 + n2;
        }

        print(resultado);

    }
}
