using System;
using System.Globalization;

namespace Exercicio1013 {

    class Program {

        static void Main(string[] args) {
            /*
            Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”

            Entrada
            O arquivo de entrada contém três valores inteiros.
            */

            int A, B, C, maior1, maior2;
            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maior1 = (A + B + Math.Abs(A - B)) / 2;
            maior2 = (maior1 + C + Math.Abs(maior1 - C)) / 2;

            Console.WriteLine(maior2 + " eh o maior");
        }
    }
}