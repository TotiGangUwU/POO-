using System;

namespace Matrices_Completo
{
    class Program
    {
        static void Main()
        {
            // ACTIVIDAD 1

            int[,] matrix1 = new int[2, 5];
            int value = 1;

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    matrix1[row, col] = value;
                    value++;
                }
            }

            Console.WriteLine("Matriz 2x5:");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(matrix1[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            
            // ACTIVIDAD 2

            int[,] matrix2 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int sum = 0;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    sum += matrix2[row, col];
                }
            }

            Console.WriteLine("La suma de los elementos es: " + sum);
        }
    }
}