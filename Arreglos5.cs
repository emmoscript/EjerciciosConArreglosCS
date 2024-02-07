// Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición se encuentra el número primo con mayor cantidad de dígitos pares.

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

    static int ContarDigitosPares(int numero)
    {
        int contador = 0;

        while (numero != 0)
        {
            int digito = numero % 10;
            if (digito % 2 == 0)
                contador++;
            numero /= 10;
        }

        return contador;
    }

    static void Main()
    {
        const int TAMANO = 10;
        int[] numeros = new int[TAMANO];
        int posicionMayorPrimoConDigitosPares = -1;
        int mayorCantidadDigitosPares = 0;

        // Leer los 10 enteros y almacenarlos en el arreglo
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write("Ingrese el entero #" + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Iterar sobre los números y encontrar el primo con la mayor cantidad de dígitos pares
        for (int i = 0; i < TAMANO; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                int cantidadDigitosPares = ContarDigitosPares(numeros[i]);
                if (cantidadDigitosPares > mayorCantidadDigitosPares)
                {
                    mayorCantidadDigitosPares = cantidadDigitosPares;
                    posicionMayorPrimoConDigitosPares = i;
                }
            }
        }

        if (posicionMayorPrimoConDigitosPares != -1)
        {
            Console.WriteLine("El número primo con la mayor cantidad de dígitos pares es " + numeros[posicionMayorPrimoConDigitosPares] + " y está en la posición " + posicionMayorPrimoConDigitosPares + " del arreglo.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún número primo con dígitos pares en el arreglo.");
        }
    }
}
