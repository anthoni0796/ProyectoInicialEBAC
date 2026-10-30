using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    // EJERCICIO 1
    private int contadorFrames = 0;
    private float contadorFixed = 1f;

    // EJERCICIO 3
    private int numeroParImpar = 0;

    // EJERCICIO 4
    public string colorCubo = "rojo";

    private Renderer objetoRenderer;

    void Start()
    {
        objetoRenderer = GetComponent<Renderer>();

        Ejercicio2();
        Ejercicio4();
        Ejercicio5();
        Ejercicio6();

        EjercicioParte2_1();
        EjercicioParte2_2();
        EjercicioParte2_3();
    }

    void Update()
    {
        // EJERCICIO 1
        contadorFrames++;

        Debug.Log("Contador de frames: " + contadorFrames);
    }

    void FixedUpdate()
    {
        // EJERCICIO 1
        contadorFixed *= 1.01f;

        Debug.Log("Contador FixedUpdate: " + contadorFixed);

        // EJERCICIO 3
        numeroParImpar++;

        if (numeroParImpar % 2 == 0)
        {
            Debug.Log(numeroParImpar + " es PAR");

            if (objetoRenderer != null)
                objetoRenderer.material.color = Color.blue;
        }
        else
        {
            Debug.Log(numeroParImpar + " es IMPAR");

            if (objetoRenderer != null)
                objetoRenderer.material.color = Color.red;
        }
    }

    // -------------------------------------------------
    // PARTE 1
    // -------------------------------------------------

    void Ejercicio2()
    {
        float numero1 = 10.5f;
        float numero2 = 4.3f;

        float resultadoFloat = numero1 + numero2;

        // Casteo explícito
        int resultadoEntero = (int)resultadoFloat;

        Debug.Log("Resultado float: " + resultadoFloat);
        Debug.Log("Resultado casteado a entero: " + resultadoEntero);
    }

    void Ejercicio4()
    {
        if (objetoRenderer == null)
            return;

        switch (colorCubo.ToLower())
        {
            case "rojo":
                objetoRenderer.material.color = Color.red;
                break;

            case "azul":
                objetoRenderer.material.color = Color.blue;
                break;

            case "verde":
                objetoRenderer.material.color = Color.green;
                break;

            case "amarillo":
                objetoRenderer.material.color = Color.yellow;
                break;

            default:
                objetoRenderer.material.color = Color.white;
                break;
        }
    }

    void Ejercicio5()
    {
        float numero = 25.12345678f;

        string numeroString = numero.ToString("F4");

        Debug.Log("Número con 4 decimales: " + numeroString);
    }

    void Ejercicio6()
    {
        string nombreCompleto = "Anthony Reyes Rodriguez";

        // SUBSTRING
        string nombre = nombreCompleto.Substring(0, 7);
        string apellido1 = nombreCompleto.Substring(8, 5);
        string apellido2 = nombreCompleto.Substring(14);

        Debug.Log("Nombre: " + nombre);
        Debug.Log("Apellido 1: " + apellido1);
        Debug.Log("Apellido 2: " + apellido2);

        // SPLIT
        string[] partesNombre = nombreCompleto.Split(' ');

        Debug.Log("Nombre separado usando Split:");

        foreach (string parte in partesNombre)
        {
            Debug.Log(parte);
        }
    }

    // -------------------------------------------------
    // PARTE 2
    // -------------------------------------------------

    void EjercicioParte2_1()
    {
        string numeroTexto1 = "5000";
        string numeroTexto2 = "3500";

        int numero1;
        int numero2;

        bool conversion1 = int.TryParse(numeroTexto1, out numero1);
        bool conversion2 = int.TryParse(numeroTexto2, out numero2);

        if (conversion1 && conversion2)
        {
            int resultado = numero1 + numero2;

            Debug.Log("Resultado TryParse: " + resultado);
        }
        else
        {
            Debug.Log("No fue posible convertir los números.");
        }
    }

    void EjercicioParte2_2()
    {
        string oracion = "Hola Mundo";

        string resultado = "";

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                resultado += oracion[i];
            }
        }

        Debug.Log("Caracteres en índices pares: " + resultado);
    }

    void EjercicioParte2_3()
    {
        string oracion = "Unity es un excelente motor de videojuegos";

        string nuevaOracion = oracion.Substring(5);

        Debug.Log("String original: " + oracion);
        Debug.Log("Sin los primeros 5 caracteres: " + nuevaOracion);
    }
}