using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            /*               
                I=1 J=60
                I=4 J=55
                I=7 J=50
                ...
                I=? J=0
            */

            int i, j;

            i = 1;
            for (j = 60; j >= 0; j -= 5) {
                Console.WriteLine("I="
                    + i
                    + " J="
                    + j);
                i += 3;
            }
        }
    }
}