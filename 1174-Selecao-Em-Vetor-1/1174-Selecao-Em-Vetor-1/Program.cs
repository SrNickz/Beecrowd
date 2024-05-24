using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1174 {
    class Program {
        static void Main(string[] args) {
            /*
            Faça um programa que leia um vetor A[100]. 
            No final, mostre todas as posições do vetor que armazenam um valor menor ou igual a 10 e o valor armazenado em cada uma das posições.

            Entrada
            A entrada contém 100 valores, podendo ser inteiros, reais, positivos ou negativos.
            */

            double[] A = new double[100];

            for(int i = 0; i < A.Length; i++) {
                double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                A[i] = N;
            }

            for(int i = 0; i < A.Length; i++) {
                if(A[i] <= 10) {
                    Console.WriteLine("A[" + i + "] " + "= " + A[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}