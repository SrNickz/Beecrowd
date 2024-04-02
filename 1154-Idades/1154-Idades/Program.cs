using System;
using System.Globalization;

namespace Exercicio1154 {

    class Program {

        static void Main(string[] args) {
            /*
            Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo.
            O último dado, que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.

            Entrada
            A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.
            */

            int idade, soma, qtdIdades;
            double media;

            idade = int.Parse(Console.ReadLine());
            soma = 0;
            qtdIdades = 0;
            while(idade >= 0) {
                soma += idade;
                qtdIdades++;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / qtdIdades;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}