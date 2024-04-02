using System;
using System.Globalization;

namespace Exercicio1078 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
            1 x N = N      2 x N = 2N        ...       10 x N = 10N

            Entrada
            A entrada contém um valor inteiro N (2 < N < 1000).
            */
            int N, resultado;

            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 20; i++) {
                resultado = N * i;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
        }
    }
}