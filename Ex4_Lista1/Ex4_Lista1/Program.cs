using System;

namespace Ex4_Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em celcius: ");
            string strCelsius = Console.ReadLine();
       
            double celsius = System.Convert.ToDouble(strCelsius);

            double tempEmFahreinheit = celsius * 1.8 + 32;

            Console.WriteLine(celsius + "C Equivale a: " + tempEmFahreinheit + "F");

        }
    }
}
