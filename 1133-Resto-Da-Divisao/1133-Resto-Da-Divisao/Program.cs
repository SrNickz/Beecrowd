using System;
using System.Globalization;

namespace Exercicio1133 {
    class Program {
        static void Main(string[] args) {
            /*
            Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.

            Entrada
            O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.
            */

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int i, menor, maior;
            
            if(x > y) {
                maior = x;
                menor = y;
            }
            else {
                maior = y;
                menor = x;
            }

            for (i = menor + 1; i < maior; i++) {
                if (i % 5 == 2 || i % 5 == 3) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}