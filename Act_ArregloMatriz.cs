using System;

class Program
{
    static void Main()
    {
        // EJERCICIO 1
        int[] folios = { 10, 14, 101, 105, 801, 1607, 2034, 5607 };

        Console.Write("Ingresa el folio: ");
        int inputFolio = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < folios.Length; i++)
        {
            if (folios[i] == inputFolio)
            {
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine("El folio es válido.");
        }
        else
        {
            Console.WriteLine("Folio no reconocido.");
        }

        Console.WriteLine(); // salto de línea

        // EJERCICIO 2
        int[] numbers = new int[10];
        int[,] matrix = new int[3, 10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingresa un número: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            matrix[0, i] = numbers[i];
            matrix[1, i] = numbers[i] * numbers[i];
            matrix[2, i] = numbers[i] * numbers[i] * numbers[i];
        }

        Console.WriteLine("\nMatriz resultante:");

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}