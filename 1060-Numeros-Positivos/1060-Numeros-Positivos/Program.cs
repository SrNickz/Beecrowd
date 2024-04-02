using System;
using System.Globalization;

namespace Exercicio1060 {

    class Program {

        static void Main(string[] args) {
            /*
            Faça um programa que leia 6 valores. 
            Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). 
            A seguir, mostre a quantidade de valores positivos digitados.

            Entrada
            Seis valores, negativos e/ou positivos.
            */

            // N é o número lido
            double N;
            int i, qtdPositivos = 0;

            for(i = 0; i < 6; i++) {
                N = double.Parse(Console.ReadLine());
                if(N > 0.0) {
                    qtdPositivos++;
                }
            }
            Console.WriteLine($"{qtdPositivos} valores positivos");
        }
    }
}