using System;
using System.Globalization;

namespace Exercicio1097 {

    class Program {

        static void Main(string[] args) {
            /*
             Fazer a sequencia
            I=1 J=7
            I=1 J=6
            I=1 J=5
            I=3 J=9
            I=3 J=8
            I=3 J=7
            ...
            I=9 J=15
            I=9 J=14
            I=9 J=13
            */

            int i, j;
            j = 7;
            for(i = 1; i <= 9; i += 2) {
                Console.WriteLine("I=" + i + " J=" + j);
                Console.WriteLine("I=" + i + " J=" + (j - 1));
                Console.WriteLine("I=" + i + " J=" + (j - 2));
                j += 2;
            }
        }
    }
}