using System;
using System.Globalization;

namespace Exercicio1143 {

    class Program {

        static void Main(string[] args) {
            /*
            Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

            Entrada
            O arquivo de entrada contém um número inteiro positivo N.
            */
            int i, N;
            N = int.Parse(Console.ReadLine());
            for(i = 1; i <= N; i++) {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2) + " ");
                Console.Write(Math.Pow(i, 3));
                Console.WriteLine();
            }
        }
    }
}