using System;
using System.Globalization;

namespace Exercicio {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero).
            Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

            Entrada
            O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo
            */

            double i, M, N, soma, menor, maior;
            string[] valores = Console.ReadLine().Split(' ');
            M = double.Parse(valores[0]);
            N = double.Parse(valores[1]);

            while (M > 0 && N > 0) {
                if (M > N) {
                    menor = N;
                    maior = M;
                }
                else {
                    menor = M;
                    maior = N;
                }

                soma = 0;
                for (i = menor; i <= maior; i++) {
                    Console.Write(i + " ");
                    soma += i;
                }
                Console.WriteLine("Sum=" + soma);

                valores = Console.ReadLine().Split(' ');
                M = double.Parse(valores[0]);
                N = double.Parse(valores[1]);
            }
        }
    }
}
