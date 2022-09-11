using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            string tm;

            Console.WriteLine("Digite um valor");
            tm = Console.ReadLine();
            num1 = int.Parse(tm);

            Console.WriteLine("Digite outro número");
            Console.ReadLine();
            num2 = int.Parse(tm);

            double resultado;

            resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado);

            resultado = num1 - num2;
            Console.WriteLine("Subtração: " + resultado);

            resultado = num1 * num2;
            Console.WriteLine("Multiplicação: " + resultado);

            resultado = num1 / num2;
            Console.WriteLine("Divisão: " + resultado);
        }
    }
}