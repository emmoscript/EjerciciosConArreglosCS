// Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo

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

    static int ContarNumerosComienzanPrimo(int[] numeros)
    {
        int contador = 0;

        foreach (int numero in numeros)
        {
            string numeroStr = numero.ToString();
            int primerDigito = int.Parse(numeroStr.Substring(0, 1));

            if (EsPrimo(primerDigito))
            {
                contador++;
            }
        }

        return contador;
    }

    static void Main()
    {
        const int TAMANO = 10;
        int[] numeros = new int[TAMANO];

        // Leer los 10 enteros y almacenarlos en el arreglo
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write("Ingrese el entero #" + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Contar cuántos números comienzan con un dígito primo
        int cantidadNumerosComienzanPrimo = ContarNumerosComienzanPrimo(numeros);

        Console.WriteLine("La cantidad de números que comienzan con un dígito primo es: " + cantidadNumerosComienzanPrimo);
    }
}
