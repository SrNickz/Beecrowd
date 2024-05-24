using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1057 {
    class Program {
        static void Main(string[] args) {
            /*
            Ler um número inteiro N e calcular todos os seus divisores.

            Entrada
            O arquivo de entrada contém um valor inteiro. 
            */

            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++) {
                if(N % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}