using System;
using System.Globalization;

namespace Exercicio1070 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

            Entrada
            A entrada será um valor inteiro positivo.
            */

            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < 6; i++) {
                if(N % 2 == 0) {
                    N++;
                }
                Console.WriteLine(N);
                N += 2;
            } 
        }
    }
}