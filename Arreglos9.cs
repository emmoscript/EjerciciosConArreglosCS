// Leer 10 números enteros, almacenarlos en un arreglo y calcular la factorial a cada uno de los números leídos almacenándolos en otro arreglo

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int[] factoriales = new int[10];

        // Leer 10 números enteros y almacenarlos en el arreglo
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Calcular el factorial de cada número y almacenarlo en el arreglo de factoriales
        for (int i = 0; i < 10; i++)
        {
            factoriales[i] = CalcularFactorial(numeros[i]);
        }

        // Mostrar los factoriales calculados
        Console.WriteLine("Factoriales de los números ingresados:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Factorial de {numeros[i]}: {factoriales[i]}");
        }
    }

    // Función para calcular el factorial de un número
    static int CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
