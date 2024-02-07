// Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitos

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int[] posiciones = new int[10];
        int contador = 0;

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Determinar posiciones de números con más de 3 dígitos
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] > 99 || numeros[i] < -99)
            {
                posiciones[contador] = i;
                contador++;
            }
        }

        // Mostrar posiciones
        if (contador > 0)
        {
            Console.WriteLine("Los números con más de 3 dígitos se encuentran en las siguientes posiciones:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Posición {posiciones[i]}");
            }
        }
        else
        {
            Console.WriteLine("No se encontraron números con más de 3 dígitos.");
        }
    }
}
