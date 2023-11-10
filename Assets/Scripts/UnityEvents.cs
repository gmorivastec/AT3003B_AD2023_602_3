using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// UnityEvent - mecanismo que sirve para hacer broadcast que informa
// que algo en particular a sucedido. Los que escuchan tienen un requisito:
// tener una firma compatible con el evento

// basado en un patrón de diseño
// https://en.wikipedia.org/wiki/Observer_pattern
public class UnityEvents : MonoBehaviour
{

    // CÓMO SABER CUÁNDO USAR UN EVENTO 
    // - cuando definimos un objeto del tipo de otro MonoBehaviour
    // hay que evaluar si sólo vamos a invocar métodos o 
    // necesitamos más información de él. Si sólo es invocar métodos
    // usa eventos.

    // podemos declarar una clase interna
    // lo utilizamos para eventos con argumentos
    [Serializable]
    public class Evento1Arg : UnityEvent<int> {}

    // evento con 2 argumentos 
    // es la misma idea de 1 a 4 
    // para entenderlo más completamente pueden checar generics
    // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
    [Serializable]
    public class Evento2Args : UnityEvent<string, float> {}

    [SerializeField]
    private UnityEvent _evento0;

    [SerializeField]
    private Evento1Arg _evento1;

    [SerializeField]
    private Evento2Args _evento2;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        // NOTA IMPORTANTE: AHORITA DETONAMOS CON TECLADO PERO
        // en su código debe ser detonado por una condición (similar a los símbolos en la 
        // máquina de estados)
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            // cuando el evento sucede invoco al unity event
            // esto va a invocar a todos los métodos que están suscritos al evento
            
            _evento0.Invoke();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            // como ejemplo lo estamos hardcodeando PERO en su código lo más probable es que 
            // venga de alguna fuente
            _evento1.Invoke(15);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _evento2.Invoke("hola amiguitos", 4.2f);
        }
    }
}
