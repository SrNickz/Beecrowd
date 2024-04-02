using System;
using System.Globalization;

namespace Exercicio1005 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno 
            sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

            Entrada
            O arquivo de entrada contém 2 valores com uma casa decimal cada um.
            */

            double notaA, notaB, pesoA, pesoB, media;
            pesoA = 3.5;
            pesoB = 7.5;

            notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoA;

            notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoB;

            media = (notaA + notaB) / (pesoA + pesoB);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
