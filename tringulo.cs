namespace Antoniks;
using System;

public class Program
{
    static void Main()
    {
        int A = 0;
        int B = 0;
        int C = 0;
        Console.WriteLine("Qual é o valor do lado A? ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual é o valor do lado B? ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual é o valor do lado C? ");
        C = Convert.ToInt32(Console.ReadLine());
        if (A < B + C & B < A + C & C < A + B)
        {
            Console.WriteLine("É um triângulo.");
        }
        else 
        { 
            Console.WriteLine("Não é um triângulo."); 
        }
        if (A == B & B == C)
        {
            Console.WriteLine("É um triângulo equilátero.");
        }
        else if (A == B & C != B) 
        {
            Console.WriteLine("É um triângulo isóceles.");
        }
        else if (A == C & B != C)
        {
            Console.WriteLine("É um triângulo isóceles.");
        }
        else if (C == B & A != B)
        {
            Console.WriteLine("É um triângulo isóceles.");
        }
        else
        {
            Console.WriteLine("É um triângulo escaleno.");
        }
    }
}
