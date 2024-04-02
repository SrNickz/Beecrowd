using System;
using System.Globalization;

namespace Exercicio10 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

            Entrada
            A entrada contem três números inteiros.
            */

            int numero1, numero2, numero3, A, B, C;

            string[] valores = Console.ReadLine().Split(' ');

            numero1 = int.Parse(valores[0]);
            numero2 = int.Parse(valores[1]);
            numero3 = int.Parse(valores[2]);

            if(numero1 > numero2 && numero1 > numero3) {
                A = numero1;
                if(numero2 > numero3) {
                    B = numero2;
                    C = numero3;
                }
                else {
                    B = numero3;
                    C = numero2;
                }
            }
            else if(numero2 > numero3) {
                A = numero2;
                if(numero1 > numero3) {
                    B = numero1;
                    C = numero3;
                }
                else {
                    B = numero3;
                    C = numero1;
                }
            }
            else {
                A = numero3;
                if(numero1 > numero2) {
                    B = numero1;
                    C = numero2;
                }
                else {
                    B = numero2;
                    C = numero1;
                }
            }

            Console.WriteLine(C);
            Console.WriteLine(B);
            Console.WriteLine(A);

            Console.WriteLine();

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);

        }
    }
}