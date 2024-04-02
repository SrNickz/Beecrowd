using System;
using System.Globalization;

namespace Exercicio1002 {

    class Program {

        static void Main(string[] args) {
            /*
            A fórmula para calcular a área de uma circunferência é: area = π.raio2.Considerando para este problema que π = 3.14159:
            Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

            A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
            */

            double raio, area, pi;

            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }       
    }
}
