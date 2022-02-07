using System;

namespace Exercício1_Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento do lado 1 do retângulo: ");
            string straltura = Console.ReadLine();

            Console.WriteLine("Digite o comprimento do lado 2 do retângulo: ");
            string strbase = Console.ReadLine();

            double lado1 = System.Convert.ToDouble(straltura);

            double base1 = System.Convert.ToDouble(strbase);

            double conta = lado1 * base1;

            Console.WriteLine("A área do terreno é de: " + conta + "m²");
         
        }
    }
}
