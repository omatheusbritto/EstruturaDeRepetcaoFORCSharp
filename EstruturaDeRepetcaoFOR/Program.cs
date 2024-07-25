// Programa que trabalha a estrutura de repetição FOR
using System;
using System.Globalization;

namespace EstruturaDeRepetcaoFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.Write("Quantos valores Deseja Digitar: ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n1; i++)
            {
                Console.Write("Digite o valor #{0}: ", i);
                int n2 = int.Parse(Console.ReadLine());
                soma += n2;
            }
            Console.WriteLine("Soma = {0}",soma);
        }
    }
}