using System;

namespace Exercicio3_Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite quantos anos você tem: ");
            string strAnos = Console.ReadLine();

            double anos = System.Convert.ToDouble(strAnos);          

            double dias = anos * 365;

            Console.WriteLine(nome + ", você ja viveu " + dias + " dias");

        }
    }
}
