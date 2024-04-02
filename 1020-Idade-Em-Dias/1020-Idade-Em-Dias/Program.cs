using System;
using System.Globalization;

namespace Exercicio1020 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
            ano = 365 dias, mês = 30 dias

            O arquivo de entrada contém um valor inteiro.
            */

            int idadeDias, resto, idadeEmAnoMesDia;

            idadeDias = int.Parse(Console.ReadLine());
            resto = idadeDias;

            idadeEmAnoMesDia = resto / 365;
            resto %= 365;
            Console.WriteLine(idadeEmAnoMesDia + " ano(s)");

            idadeEmAnoMesDia = resto / 30;
            resto %= 30;
            Console.WriteLine(idadeEmAnoMesDia + " mes(es)");

            Console.WriteLine(resto + " dia(s)");
        }
    }
}
