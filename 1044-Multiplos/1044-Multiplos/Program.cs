using System;
using System.Globalization;

namespace Exercicio1044 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

            Entrada
            A entrada contém valores inteiros.
            */

            int A, B;

            string[] numeros = Console.ReadLine().Split(' ');
            A = int.Parse(numeros[0]);
            B = int.Parse(numeros[1]);

            if(B % A == 0 || A % B == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}