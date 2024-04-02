using System;
using System.Globalization;

namespace Exercicio1007 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: 
            DIFERENCA = (A * B - C * D).

            Entrada
            O arquivo de entrada contém 4 valores inteiros.
            */

            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            diferenca = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}