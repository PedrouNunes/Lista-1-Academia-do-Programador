using System;

namespace Exercicio5_Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal aumentoSalario = 0.15m;
            const decimal impostoSalario = 0.8m;

            decimal salario, aumento, desconto;

            Console.WriteLine("Digite o salário do funcionário: ");
            salario = System.Convert.ToDecimal(Console.ReadLine();

            aumento = salario + (salario * aumentoSalario);

            desconto = aumento - (aumento * impostoSalario);

            Console.WriteLine("Salário inicial: R$" + salario + ", salário com aumento: R$" + aumento + ", salário com desconto: R$" + desconto);

        }
    }
}
