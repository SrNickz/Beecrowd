using System;
using System.Globalization;

namespace Testes {

    class Program {

        static void Main(string[] args) {

            //double soma, idade, media;
            //int qtdIdades;

            //soma = 0.0;
            //idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //qtdIdades = 0;

            //while (idade >= 0.0) {
            //    qtdIdades++;
            //    soma += idade;
            //    idade = double.Parse(Console.ReadLine());
            //}

            //media = soma / qtdIdades;

            //if(qtdIdades == 0) {
            //    Console.WriteLine("Impossivel Calcular");
            //}
            //else {
            //    Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            //}

            //int i, j, M, N, soma;
            //string[] s = Console.ReadLine().Split(' ');
            //M = int.Parse(s[0]);
            //N = int.Parse(s[1]);

            //int[,] A = new int[M, N];

            //soma = 0;
            //for(i = 0; i < M; i++) {
            //    s = Console.ReadLine().Split(' ');
            //    for(j = 0; j < N; j++) {
            //        A[i, j] = int.Parse(s[j]);
            //        soma += A[i, j];
            //    }
            //    Console.WriteLine(soma);
            //    soma = 0;
            //}

            int i, N;
            N = int.Parse(Console.ReadLine());

            for(i = 1; i <= N; i++) {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2) + " ");
                Console.Write(Math.Pow(i, 3));
                Console.WriteLine();
            }

        } 
    }
}