using System;
using System.Globalization;

namespace Exercicio1142 {
    class Program {
        static void Main(string[] args) {
            /*
            Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

            Entrada
            O arquivo de entrada contém um número inteiro positivo N.
            */

            int i, j, numeroConsole = 1; ;
            int N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++) {
                for (j = 1; j <= 3; j++) {
                    Console.Write(numeroConsole + " ");

                    if (j != 3) {
                        numeroConsole++;
                    }
                }
                numeroConsole += 2;
                Console.Write("PUM");
                Console.WriteLine();
            }
        }
    }
}