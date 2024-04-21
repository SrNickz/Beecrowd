using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1173 {
    class Program {
        static void Main(string[] args) {
            /*
            Leia um valor e faça um programa que coloque o valor lido na primeira posição de um vetor N[10].
            Em cada posição subsequente, coloque o dobro do valor da posição anterior. 
            Por exemplo, se o valor lido for 1, os valores do vetor devem ser 1,2,4,8 e assim sucessivamente. 
            Mostre o vetor em seguida.

            Entrada
            A entrada contém um valor inteiro (V<=50). 
            */

            int[] vet = new int[10];
            int N = int.Parse(Console.ReadLine());
            vet[0] = N;

            for (int i = 1; i < vet.Length; i++) {
                vet[i] = vet[i - 1] * 2;
            }
            for (int i = 0; i < vet.Length; i++) {
                Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}