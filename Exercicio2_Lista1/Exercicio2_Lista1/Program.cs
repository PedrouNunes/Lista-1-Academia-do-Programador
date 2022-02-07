using System;

namespace Exercicio2_Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pães franceses vendidos hoje: ");
            string strpaes = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de broas vendidas hoje: ");
            string strbroas = Console.ReadLine();

            double paes = System.Convert.ToDouble(strpaes);

            double broas = System.Convert.ToDouble(strbroas);

            double arrecadado = (paes * 0.12) + (broas * 1.5);

            double guardar = arrecadado * 0.10;

            Console.WriteLine("O valor arrecadado de hoje foi: R$" + arrecadado + ", e o valor a ser guardado na poupança é de: R$" + guardar);

        }
    }
}
