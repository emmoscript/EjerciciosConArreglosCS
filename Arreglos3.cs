// Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.

using System;

class Program
{
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero == 2)
            return true;
        if (numero % 2 == 0)
            return false;

        int raiz = (int)Math.Sqrt(numero);

        for (int i = 3; i <= raiz; i += 2)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        const int TAMANO = 10;
        int[] numeros = new int[TAMANO];
        int mayorPrimo = int.MinValue;
        int posicionMayorPrimo = -1;

        // Leer los 10 enteros y almacenarlos en el arreglo
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write("Ingrese el entero #" + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número es primo y mayor que el mayor primo encontrado hasta ahora
            if (EsPrimo(numeros[i]) && numeros[i] > mayorPrimo)
            {
                mayorPrimo = numeros[i];
                posicionMayorPrimo = i;
            }
        }

        // Mostrar el arreglo
        Console.Write("Los números ingresados son: ");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        if (posicionMayorPrimo != -1)
        {
            // Mostrar la posición del mayor número primo
            Console.WriteLine("El mayor número primo ingresado es " + mayorPrimo + " y está en la posición " + posicionMayorPrimo + " del arreglo.");
        }
        else
        {
            Console.WriteLine("No se ingresaron números primos.");
        }
    }
}
