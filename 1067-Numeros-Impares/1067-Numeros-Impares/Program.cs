using System;
using System.Globalization;

namespace Exercicio {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

            Entrada
            O arquivo de entrada contém 1 valor inteiro qualquer.             
            */

            int x = int.Parse(Console.ReadLine()), i;

            for(i = 1; i <=x ; i++) {
                if(i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}