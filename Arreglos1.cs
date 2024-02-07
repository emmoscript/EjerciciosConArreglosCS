// Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.

using System;

class Program
{
    static void Main()
    {
        const int DIMENSION = 10;
        int[] numeros = new int[DIMENSION];
        int mayor = int.MinValue;
        int posicionMayor = 0;

        // Leer los 10 enteros y almacenarlos en el arreglo
        for (int i = 0; i < DIMENSION; i++)
        {
            Console.Write("Ingrese el entero #" + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número es mayor que el mayor encontrado hasta ahora
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicionMayor = i;
            }
        }

        // Mostrar el arreglo
        Console.Write("Los números ingresados son: ");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Mostrar la posición del mayor número
        Console.WriteLine("El mayor número ingresado es " + mayor + " y está en la posición " + posicionMayor + " del arreglo.");
    }
}
