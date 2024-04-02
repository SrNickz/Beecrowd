using System;
using System.Globalization;

namespace Exercicio {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. 
            Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

            Entrada
            A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.
            */

            int qtdPositivos;
            double N, somaPositivos, media;

            qtdPositivos = 0;
            somaPositivos = 0;  
            for(int i = 0; i < 6; i++) {
                N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(N > 0) {
                    qtdPositivos++;
                    somaPositivos += N;
                }
            }
            media = somaPositivos / qtdPositivos;

            Console.WriteLine(qtdPositivos + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));   
        }
    }
}