using System;
using System.Globalization;

namespace Exercicio1003 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável.

            Entrada
            O arquivo de entrada contém 2 valores inteiros. 
            */

            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
