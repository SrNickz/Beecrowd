using System;
using System.Globalization;

namespace Exercicio1009 {

    class Program {

        static void Main(string[] args) {
            /*
            Faça um programa que leia o nome de um vendedor, o seu salário fixo
            e o total de vendas efetuadas por ele no mês(em dinheiro).Sabendo que este vendedor ganha 15 % de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.


            Entrada
            O arquivo de entrada contém um texto(primeiro nome do vendedor) e 2 valores de dupla precisão(double) com duas casas decimais,
            representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.
            */

            string name;
            double fixedSalary, sales, total;

            name = Console.ReadLine();
            fixedSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = fixedSalary + (sales * .15);

            Console.WriteLine("TOTAL = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}