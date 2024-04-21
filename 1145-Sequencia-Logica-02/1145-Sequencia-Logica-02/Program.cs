using System;
using System.Globalization;

namespace Exercicio1145 {
    class Program {
        static void Main(string[] args) {
            /*
            Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

            Entrada
            O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).
            */

            int x, y, i, j, k;
            string[] ordens = Console.ReadLine().Split(' ');
            x = int.Parse(ordens[0]);
            y = int.Parse(ordens[1]);

            for (i = 1; i <= y; i++) {
                Console.Write(i);
                if (i % x == 0) {
                    Console.WriteLine();
                }
                else {
                    Console.Write(" ");
                }

            }
        }
    }
}