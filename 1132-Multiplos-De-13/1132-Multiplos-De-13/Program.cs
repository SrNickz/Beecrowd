using System;
using System.Globalization;

namespace Exercicio1132 {
    class Program {
        static void Main(string[] args) {
            /*
            Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.

            Entrada
            O arquivo de entrada contém 2 valores inteiros quaisquer, não necessariamente em ordem crescente.
            */

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int soma = 0;
            int i, menor, maior;

            if (X > Y) {
                maior = X;
                menor = Y;
            }
            else {
                maior = Y;
                menor = X;
            }

            for (i = menor; i <= maior; i++) {
                if (i % 13 != 0) {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}