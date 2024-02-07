// Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.

using System;

class Program
{
    static void Main()
    {
        const int TAMANO = 10;
        int[] numeros = new int[TAMANO];
        int mayorPar = int.MinValue;
        int posicionMayorPar = -1;

        // Leer los 10 enteros y almacenarlos en el arreglo
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write("Ingrese el entero #" + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número es par y mayor que el mayor par encontrado hasta ahora
            if (numeros[i] % 2 == 0 && numeros[i] > mayorPar)
            {
                mayorPar = numeros[i];
                posicionMayorPar = i;
            }
        }

        // Mostrar el arreglo
        Console.Write("Los números ingresados son: ");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        if (posicionMayorPar != -1)
        {
            // Mostrar la posición del mayor número par
            Console.WriteLine("El mayor número par ingresado es " + mayorPar + " y está en la posición " + posicionMayorPar + " del arreglo.");
        }
        else
        {
            Console.WriteLine("No se ingresaron números pares.");
        }
    }
}
