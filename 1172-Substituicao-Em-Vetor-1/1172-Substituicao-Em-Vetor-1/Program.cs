using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1172 {
    class Program {
        static void Main(string[] args) {
            /*
            Faça um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1. Em seguida mostre o vetor X.

            Entrada
            A entrada contém 10 valores inteiros, podendo ser positivos ou negativos.
            */

            int[] vet = new int[10];

            for(int i = 0; i < vet.Length; i++) {
                vet[i] = int.Parse(Console.ReadLine());

                if(vet[i] <= 0) {
                    vet[i] = 1;
                }
            }

            for(int i = 0; i < vet.Length; i++) {
                Console.WriteLine($"X[{i}] = {vet[i]}");
            }
        }
    }
}