using System;
using System.Globalization;

namespace Exercicio1080 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

            Entrada
            O arquivo de entrada contém 100 números inteiros, positivos e distintos.
            */

            int n, maior, posicaoEntrada, i;
            maior = 0;
            posicaoEntrada = 0;
            
            for(i = 1; i <= 100; i++) {
                n = int.Parse(Console.ReadLine());
                if(n > maior) {
                    maior = n;
                    posicaoEntrada = i;
                }
            }
            Console.WriteLine(maior + "\n" + posicaoEntrada);
        }
    }
}