using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener1 : MonoBehaviour
{

    // métodos para escuchar eventos
    // IMPORTANTE: asegurarse que reciban los argumentos que lanza
    // el evento
    public void Escuchar0()
    {
        print("LISTENER 1, EVENTO 0");
    }

    public void Escuchar1(int valor)
    {
        print(string.Format("LISTENER {0}, EVENTO {1}, VALOR: {2}", 1, 1, valor));
    }

    public void Escuchar2(string valor1, float valor2)
    {
        print(
            string.Format(
                "LISTENER {0}, EVENTO {1}, VALOR: {2} {3}", 
                1, 
                1, 
                valor1, 
                valor2
            )
        );
    }
}
