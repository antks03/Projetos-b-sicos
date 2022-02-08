namespace Antoniks;
using System;

public class Program
{
    static void Main()
    {
        int A = 0;
        int B = 0;
        int C = 0;
        Console.WriteLine("Insert a number here: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert other number here: ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert the last number here: ");
        C = Convert.ToInt32(Console.ReadLine());

        if (A < B & B < C)
        {
            Console.WriteLine($"{C}, {B}, {A}");
        }
        else if (A > C & B < C)
        {
            Console.WriteLine($"{A}, {B}, {C}");
        }
        else if (C > B & C < A)
        {
            Console.WriteLine($"{A}, {C}, {B}");
        }
        else if (B > C & C < A)
        {
            Console.WriteLine($"{B}, {A}, {C}");
        }
        else if (C > A & B < C)
        {
            Console.WriteLine($"{C}, {A}, {B}");
        }
        else if (B > C & C > A) 
        {
            Console.WriteLine($"{B}, {C}, {A}");
        }
    }
}
