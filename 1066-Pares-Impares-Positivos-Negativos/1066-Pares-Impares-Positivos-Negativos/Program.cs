using System;
using System.Globalization;

namespace Exercicio1066 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, 
            quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

            Entrada
            O arquivo de entrada contém 5 valores inteiros quaisquer.
            */

            int i, N, qtdPares, qtdImpares, qtdPositivos, qtdNegativos;

            qtdPares = 0;
            qtdImpares = 0; 
            qtdPositivos = 0;
            qtdNegativos = 0;
            for(i = 0; i < 5; i++){
                N = int.Parse(Console.ReadLine());
                if(N % 2 == 0) {
                    qtdPares++;
                }
                else {
                    qtdImpares++;
                }
                
                if(N > 0) {
                    qtdPositivos++;
                }
                else if(N < 0 && N != 0){
                    qtdNegativos++;
                }
            }
            Console.WriteLine(qtdPares + " valor(es) par(es)");
            Console.WriteLine(qtdImpares + " valor(es) impar(es)");
            Console.WriteLine(qtdPositivos + " valor(es) positivo(s)");
            Console.WriteLine(qtdNegativos + " valor(es) negativo(s)");
        }
    }
}