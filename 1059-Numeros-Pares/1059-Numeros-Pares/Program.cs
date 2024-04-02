using System;
using System.Globalization;

namespace Exercicio1059 {

    class Program {

        static void Main(string[] args) {
            /*
            Faça um programa que mostre os números pares entre 1 e 100, inclusive.

            Entrada
            Neste problema extremamente simples de repetição não há entrada.
            */

            for(int i = 1; i <= 100; i++) {
                if(i % 2 == 0) Console.WriteLine(i);
            }
        }
    }
}