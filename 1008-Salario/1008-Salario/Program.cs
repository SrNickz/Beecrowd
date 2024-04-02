using System;
using System.Globalization;

namespace Exercicio1008 {

    class Program {

        static void Main(string[] args) {
            /*
            Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. 
            A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            Entrada
            O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas
            e o valor que o funcionário recebe por hora trabalhada, respectivamente.
            */

            int number, workedHours;
            double salaryPerHours, salary;

            number = int.Parse(Console.ReadLine());
            workedHours = int.Parse(Console.ReadLine());
            salaryPerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salary = (double)salaryPerHours * workedHours;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}