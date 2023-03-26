using System;

namespace OperacoesNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("A - somar");
            Console.WriteLine("S - subtrair");
            Console.WriteLine("M - multiplicar");
            Console.WriteLine("Q - quociente inteiro da divisão");
            Console.WriteLine("E - sair");

            string opcao = Console.ReadLine();

            switch (opcao.ToUpper())
            {
                case "A":
                    Console.WriteLine($"A soma é: {num1 + num2}");
                    break;
                case "S":
                    Console.WriteLine($"A diferença é: {num1 - num2}");
                    break;
                case "M":
                    Console.WriteLine($"O produto é: {num1 * num2}");
                    break;
                case "Q":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: divisão por zero");
                    }
                    else
                    {
                        Console.WriteLine($"O quociente inteiro da divisão é: {num1 / num2}");
                    }
                    break;
                case "E":
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Erro: opção inválida");
                    break;
            }
        }
    }
}
