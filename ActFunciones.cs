using System;

class Program
{
    static bool numberIseven(int n)
    {
        return n % 2 == 0;
    }

    static void Main()
    {
        Console.Write("Introduzca un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (numberIseven(n))
            Console.WriteLine(n + " es par.");
        else
            Console.WriteLine(n + " es impar.");
    }
}