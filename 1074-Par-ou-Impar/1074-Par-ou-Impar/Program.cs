using System;
using System.Globalization;

namespace Exercicio {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida.
            Para cada valor lido, mostre uma mensagem em inglês dizendo se este valor lido é par (EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE).
            No caso do valor ser igual a zero (0), embora a descrição correta seja (EVEN NULL), pois por definição zero é par, seu programa deverá imprimir apenas NULL.

            Entrada
            A primeira linha da entrada contém um valor inteiro N(N < 10000) que indica o número de casos de teste. Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).        
            */

            int numLidos, valLido, i;

            numLidos = int.Parse(Console.ReadLine());

            for(i = 1; i <= numLidos; i++) {
                valLido = int.Parse(Console.ReadLine());

                if(valLido == 0) {
                    Console.WriteLine("NULL");
                }
                else if(valLido % 2 == 0) {// PAR - EVEN
                    if(valLido > 0) {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else if(valLido % 2 != 0) { // IMPAR - ODD
                    if(valLido > 0) {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}