using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static public void Menu(short error = 0)
        {
            if (error != 0)
                Error();

            Console.Clear();
            Console.WriteLine("========= CALCULADORA ============");
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            short operation = short.Parse(Console.ReadLine());            

            switch(operation)
            {
                case 1: Run("SOMA"); break;
                case 2: Run("SUBTRAÇÃO"); break;
                case 3: Run("MULTIPLICAÇÃO"); break;
                case 4: Run("DIVISÃO"); break;
                case 5: Exit(); break;
                default: Menu(1); break;
            }
        }

        public static void Error()
        {
            Console.Clear();
            Console.WriteLine("OPÇÃO INVÁLIDA");
            Console.WriteLine("Pressione <Enter> para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Run(string operation)
        {
            Console.WriteLine($"=== {operation} ===");
            Console.Write("Primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            int v2 = int.Parse(Console.ReadLine());
            double result = Calculate(operation, v1, v2);
            Console.WriteLine($"Resultado: {result}");
            Console.WriteLine("Pressione <Enter> para continuar");
            Console.ReadKey();
            Menu();
        }

        static double Calculate(string operation, double v1, double v2)
        {
            double result;
            switch (operation)
            {
                case "SOMA":
                    result = v1 + v2;
                    break;
                case "SUBTRAÇÃO":
                    result = v1 - v2;
                    break;
                case "MULTIPLICAÇÃO":
                    result = v1 * v2;
                    break;
                case "DIVISÃO":
                    result = v1 / v2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        static public void Exit(){
            Console.Clear();
            Console.WriteLine("Saindo...");
            System.Environment.Exit(0); 
        }

    }

}