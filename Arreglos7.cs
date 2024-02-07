// Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int suma = 0;

        // Leer 10 números enteros y almacenarlos en el arreglo
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }

        // Calcular el promedio entero
        int promedio = suma / 10;

        // Mostrar el promedio entero
        Console.WriteLine($"El promedio entero de los datos del arreglo es: {promedio}");
    }
}
