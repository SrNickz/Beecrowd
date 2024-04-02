using System;
using System.Globalization;

namespace Exercicio1116 {

    class Program {

        static void Main(string[] args) {
            /*
            Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

            Entrada
            A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.
            */

            int N, X, Y, i;
            double resultado;

            N = int.Parse(Console.ReadLine());

            for(i = 1; i <= N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);

                if(Y == 0.0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    resultado = (double) X / Y;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}