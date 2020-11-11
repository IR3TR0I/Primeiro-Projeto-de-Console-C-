using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            string num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);

            Console.WriteLine("Digite o segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            Console.Write("O resultado: ");
            Console.WriteLine(soma);
        }   
    }
}
