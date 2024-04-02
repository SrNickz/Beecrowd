using System;
using System.Globalization;

namespace Exercicio1017 {

    class Program {

        static void Main(string[] args) {
            int tempoViagem, velMedia;
            double qtdLitrosNecessaria;


            tempoViagem = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velMedia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            qtdLitrosNecessaria = (double)(tempoViagem * velMedia) / 12.0;

            Console.WriteLine(qtdLitrosNecessaria.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

