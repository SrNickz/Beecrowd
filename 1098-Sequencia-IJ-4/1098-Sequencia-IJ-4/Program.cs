using System;
using System.Globalization;

namespace Exercicio1098 {
    class Program {
        static void Main(string[] args) {
            /*
            Sequencia:
                I=0 J=1
                I=0 J=2
                I=0 J=3
                I=0.2 J=1.2
                I=0.2 J=2.2
                I=0.2 J=3.2
                .....
                I=2 J=?
                I=2 J=?
                I=2 J=?
            */

            double i, j;

            for (i = 0; i <= 2; i += .2) {
                for (j = 1; j <= 3; j++) {
                    i *= 5;
                    j *= 5;

                    j += i;

                    i /= 5;
                    j /= 5;

                    if (i == 0 || i == 1 || i == 2) {
                        Console.WriteLine("I=" + i + " J=" + j);
                    }
                    else {
                        Console.WriteLine("I="
                            + i.ToString("F1", CultureInfo.InvariantCulture)
                            + " J="
                            + j.ToString("F1", CultureInfo.InvariantCulture));
                    }

                    j -= i;
                }
            }
        }
    }
}