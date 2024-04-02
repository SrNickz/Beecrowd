using System;
using System.Globalization;

namespace Exercicio1075 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.

            Entrada
            A entrada contém um valor inteiro N (N < 10000).
            */

            int N, i;

            N = int.Parse(Console.ReadLine());
            
            for(i = 1; i <= 10000; i++) {
                if(i % N == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}