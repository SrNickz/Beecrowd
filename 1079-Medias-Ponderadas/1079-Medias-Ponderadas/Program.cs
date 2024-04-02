using System;
using System.Globalization;

namespace Exercicio {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
            Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

            Entrada
            O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.
            */

            int numTestes = int.Parse(Console.ReadLine()), i;
            double nota1, nota2, nota3, media;
            for(i = 1; i <= numTestes; i++) {
                string[] notas = Console.ReadLine().Split(' ');

                nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
                media = ((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 5.0)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}