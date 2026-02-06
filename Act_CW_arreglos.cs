using System;

namespace CW_arreglos
{
    class Program
    {
        static void Main()
        {
            Console.Write("¿Cuántos salarios hay? ");
            int amount = int.Parse(Console.ReadLine()!);

            double[] salaries = new double[amount];
            double sum = 0;

            for (int i = 0; i < amount; i++)
            {
                Console.Write($"Enter salary #{i + 1}: ");
                salaries[i] = double.Parse(Console.ReadLine()!);
                sum += salaries[i];
            }

            double average = sum / amount;

            Console.WriteLine($"\nEl salaliro promedio es?: {average}");
            Console.WriteLine("Salario arriva del promedio?:");

            for (int i = 0; i < amount; i++)
            {
                if (salaries[i] > average)
                {
                    Console.WriteLine(salaries[i]);
                }
            }
        }
    }
}
