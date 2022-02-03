using System;
					
public class Program
{
	public static void Main()
	{
		int precopeca1 = 32;
		int precopeca2 = 55;
		int precopeca3 = 25;
		int codigopeca = 0;
		int qtd = 0;
		Console.Write("Digite o seu nome: ".ToUpper());
		var nomevendedor = Convert.ToString(Console.ReadLine());
		Console.Write("Digite o código da peça: ".ToUpper());
		codigopeca = Convert.ToInt32(Console.ReadLine());
		Console.Write("Digite o número de peças vendidas: ".ToUpper());
		qtd = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("---------------------------------------");
		switch(codigopeca)
		{
			case 1:
					Console.WriteLine("NOME: " + nomevendedor.ToUpper() + "\n" + "CÓDIGO DA PEÇA: " + codigopeca + "\n" + "preço da peça: ".ToUpper() + precopeca1 + " reais" + "\n" + "VALOR PAGO: " + (5*precopeca1*qtd)/100 + " reais");
				break;
			case 2:
					Console.WriteLine("NOME: " + nomevendedor.ToUpper() + "\n" + "CÓDIGO DA PEÇA: " + codigopeca + "\n" + "preço da peça: ".ToUpper() + precopeca2 + " reais" + "\n" + "VALOR PAGO: " + (5*precopeca2*qtd)/100 + " reais");
				break;
			case 3:
					Console.WriteLine("NOME: " + nomevendedor.ToUpper() + "\n" + "CÓDIGO DA PEÇA: " + codigopeca + "\n" + "preço da peça: ".ToUpper() + precopeca3 + " reais" + "\n" + "VALOR PAGO: " + (5*precopeca1*qtd)/100 + " reais" );
				break;	
			default:
					Console.WriteLine("Não há um código com esse número.");
				break;
		}
	}
}
