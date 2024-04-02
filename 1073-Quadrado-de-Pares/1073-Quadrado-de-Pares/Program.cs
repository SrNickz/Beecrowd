using System;
using System.Globalization;

namespace Exercicio1073 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.

            Entrada
            A entrada contém um valor inteiro N (5 < N < 2000).  
            */

            int N, quadrado;
            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++) {
                if(i % 2 == 0) {
                    quadrado = (int) Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        }
    }
}