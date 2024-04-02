using System;
using System.Globalization;

namespace Exercicio1096 {

    class Program {

        static void Main(string[] args) {
            /*
             Fazer a sequencia
            I=1 J=7
            I=1 J=6
            I=1 J=5
            I=3 J=7
            I=3 J=6
            I=3 J=5
            ...
            I=9 J=7
            I=9 J=6
            I=9 J=5
            */

            int i, j;

            for(i = 1; i <= 9; i += 2) {
                for(j = 7; j >= 5; j--) {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
        }
    }
}