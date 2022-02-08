namespace Antoniks;
using System;

public class Program
{
    static void Main()
    {
        int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;
        int nota4 = 0;
        int media = 0;
        Console.WriteLine("Digite o seu nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite a sua nota no primeiro bimestre: ");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a sua nota no segundo bimestre: ");
        nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a sua nota no terceiro bimestre: ");
        nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a sua nota no quarto bimestre: ");
        nota4 = Convert.ToInt32(Console.ReadLine());
        media = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("\n");
        if (media >= 5)
        {
            Console.WriteLine($"Nome: {nome} \nMédia final: {media} \nSituação: Aprovado");
        }
        else 
        {
            Console.WriteLine($"Nome: {nome} \nMédia final: {media} \nSituação: Reprovado");
        }
    }
}
