using System;
using System.Globalization;

namespace Exercicio1065 {

    class Program {

        static void Main(string[] args) {
            /*
            Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

            Entrada
            O arquivo de entrada contém 5 valores inteiros quaisquer.
            */

            int i, N, qtdPares;

            qtdPares = 0;
            for(i = 0; i < 5; i++) {
                N = int.Parse(Console.ReadLine());
                if(N % 2 == 0) {
                    qtdPares++;
                }
            }
            Console.WriteLine(qtdPares + " valores pares");
        }
    }
}