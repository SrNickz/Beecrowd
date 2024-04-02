using System;
using System.Globalization;

namespace Exercicio1006 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, 
            sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

            Entrada
            O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
            */

            double notaA, notaB, notaC, pesoA, pesoB, pesoC, media;

            pesoA = 2;
            pesoB = 3;
            pesoC = 5;

            notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoA;
            notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoB;
            notaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * pesoC;

            media = (notaA + notaB + notaC) / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
