using System;
using System.Globalization;

namespace Exercicio1043 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
            Perimetro = XX.X


            Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
            Area = XX.X
            Entrada
            A entrada contém três valores reais.
            */

            double A, B, C, area, perimetro;
            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if((A > Math.Abs(B - C) && A < (B + C)) || (B > Math.Abs(A - C) && B < (A + C)) || (C > Math.Abs(A - B) && C < (A + B))) {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                area = (((A + B) * C) / 2.0);
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}