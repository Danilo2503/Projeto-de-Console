using System;

namespace Projeto_de_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm;
            int valorDois;

            Console.WriteLine("Soma de dois números");
            Console.WriteLine("---------------------");

            Console.WriteLine("Digite o primeiro número:");
            valorUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            valorDois = int.Parse(Console.ReadLine());

            int soma = valorUm + valorDois;

            Console.WriteLine("A soma de" +valorUm+ "+" +valorDois+ "=" +soma);
        }
    }
}
