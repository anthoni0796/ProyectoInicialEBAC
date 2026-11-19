using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ejercicio 1
        List<int> numeros = GenerarNumerosAleatorios(5, 1, 10);

        foreach (int numero in numeros)
        {
            Debug.Log(numero);
        }

        //ejercicio 2
        int[] numerosOriginales = { 5, 2, 9, 1, 7 };
        int[] numerosOrdenados = OrdenarDescendente(numerosOriginales);

        foreach (int numero in numerosOrdenados)
        {
            Debug.Log(numero);
        }

        // Ejercicio 3 - Prueba
        List<int> numerosRepetidos = new List<int>
        {
            2, 5, 2, 8, 5, 10, 8
        };

        HashSet<int> numerosSinDuplicados =
            EliminarDuplicados(numerosRepetidos);

        Debug.Log("Ejercicio 3 - Números sin duplicados:");

        foreach (int numero in numerosSinDuplicados)
        {
            Debug.Log(numero);
        }

        // Ejercicio 4 - Prueba
        Stack<string> pila = new Stack<string>();

        pila.Push("Primero");
        pila.Push("Segundo");
        pila.Push("Tercero");

        ConvertirPilaACola(pila);

    }

    //ejercicio 2
    public int[] OrdenarDescendente(int[] numeros)
    {
        int[] numerosOrdenados = (int[])numeros.Clone();

        System.Array.Sort(numerosOrdenados);
        System.Array.Reverse(numerosOrdenados);

        return numerosOrdenados;
    }

    //ejercicio 3
    public HashSet<int> EliminarDuplicados(List<int> numeros)
    {
        HashSet<int> numerosUnicos = new HashSet<int>();

        foreach (int numero in numeros)
        {
            numerosUnicos.Add(numero);
        }

        return numerosUnicos;
    }

    // Ejercicio 4
    public void ConvertirPilaACola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();

        Debug.Log("Ejercicio 4 - Elementos de la pila:");

        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            Debug.Log(elemento);

            cola.Enqueue(elemento);
            pila.Pop();
        }

        Debug.Log("Ejercicio 4 - Elementos de la cola:");

        while (cola.Count > 0)
        {
            Debug.Log(cola.Peek());
            cola.Dequeue();
        }
    }

    public List<int> GenerarNumerosAleatorios(
        int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            int numero = Random.Range(rangoInferior, rangoSuperior + 1);
            numeros.Add(numero);
        }

        return numeros;

    }
}
