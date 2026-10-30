
using UnityEngine;

public class EjerciciosDeCiclosYArreglos : MonoBehaviour
{
    void Start()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
    }

    // EJERCICIO 1: Suma de arreglos
    void Ejercicio1()
    {
        Debug.Log("=== EJERCICIO 1 ===");

        int[] arreglo1 = new int[5];
        int[] arreglo2 = new int[5];
        int[] arreglo3 = new int[5];

        for (int i = 0; i < arreglo1.Length; i++)
        {
            arreglo1[i] = Random.Range(1, 11);
            arreglo2[i] = Random.Range(1, 11);

            arreglo3[i] = arreglo1[i] + arreglo2[i];

            Debug.Log(arreglo1[i] + " + " +
                      arreglo2[i] + " = " + arreglo3[i]);
        }
    }

    // EJERCICIO 2: Concatenar palabras
    void Ejercicio2()
    {
        Debug.Log("=== EJERCICIO 2 ===");

        string[] palabras =
        {
            "Estoy", "aprendiendo", "a",
            "desarrollar", "videojuegos",
            "con", "Unity"
        };

        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }

        Debug.Log(oracion.Trim());
    }

    // EJERCICIO 3: Multiplicacion matriz-vector
    void Ejercicio3()
    {
        Debug.Log("=== EJERCICIO 3 ===");

        int[,] matriz =
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[] vector = { 2, 3, 4 };
        int[] resultado = new int[2];

        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            resultado[fila] = 0;

            for (int columna = 0;
                 columna < matriz.GetLength(1);
                 columna++)
            {
                resultado[fila] +=
                    matriz[fila, columna] * vector[columna];
            }

            Debug.Log("Resultado fila " + fila +
                      ": " + resultado[fila]);
        }
    }
}
