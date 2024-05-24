using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1180
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que leia um valor N. 
            Este N será o tamanho de um vetor X[N]. 
            A seguir, leia cada um dos valores de X, encontre o menor elemento deste vetor e a sua posição dentro do vetor, mostrando esta informação.

            Entrada
            A primeira linha de entrada contem um único inteiro N (1 < N < 1000), 
            indicando o número de elementos que deverão ser lidos em seguida para o vetor X[N] de inteiros. 
            A segunda linha contém cada um dos N valores, separados por um espaço. Vale lembrar que nenhuma entrada haverá números repetidos. 
            */

            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            int smallNumber, position;
            string[] values = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(values[i]);
            }

            smallNumber = vet[0];
            position = 0;

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < smallNumber)
                {
                    smallNumber = vet[i];
                    position = i;
                }
            }

            Console.WriteLine("Menor valor: " + smallNumber);
            Console.WriteLine("Posicao: " + position);
        }
    }
}