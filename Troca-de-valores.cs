namespace Antoniks;
using System;

public class Antoniks
{
    static void Main()
    {
        int A = 0;
        int B = 0;
        int C = 0;
        Console.Write("Escreva o primeiro número: ");
        A = Convert.ToInt32(Console.ReadLine()) ;
        Console.Write("Escreva o segundo número: ");
        B = Convert.ToInt32(Console.ReadLine());

        C = A;
        A = B;
        B = C;

        Console.WriteLine($"Agora 'A' é igual  a {A} e 'B' é igual a {B}.");

    }
}
