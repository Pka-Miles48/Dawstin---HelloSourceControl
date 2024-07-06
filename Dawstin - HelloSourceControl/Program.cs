// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hi, GitHub!");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Number: {i}");
            Console.WriteLine($"Square of {i}: {Square(i)}");
            Console.WriteLine($"Cube of {i}: {Cube(i)}");
        }
    }

    static int Square(int number)
    {
        return number * number;
    }

    static int Cube(int number)
    {
        return number * number * number;
    }
}
