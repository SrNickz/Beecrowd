using System;
using System.Globalization;

namespace Exercicio {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.

            Entrada
            A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
            Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
            */

            int N, X, i, inInterval, outInterval;

            N = int.Parse(Console.ReadLine());

            inInterval = 0;
            outInterval = 0;
            for(i = 1; i <= N; i++) {
                X = int.Parse(Console.ReadLine());

                if(X <= 20 && X >= 10) {
                    inInterval++;
                }
                else {
                    outInterval++;
                }
            }

            Console.WriteLine(inInterval + " in" + "\n" + outInterval + " out");
        }
    }
}