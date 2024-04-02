using System;
using System.Globalization;

namespace Exercicio1012 {

    class Program {

        static void Main(string[] args) {
            /*
            Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.

            Entrada
            O arquivo de entrada contém três valores com um dígito após o ponto decimal.
            */

            double A, B, C, pi, aTriangulo, aTrapezio, aCirculo, aQuadrado, aRetangulo;

            pi = 3.14159;

            string[] valoresLetras = (Console.ReadLine()).Split(' ');

            A = double.Parse(valoresLetras[0], CultureInfo.InvariantCulture);
            B = double.Parse(valoresLetras[1], CultureInfo.InvariantCulture);
            C = double.Parse(valoresLetras[2], CultureInfo.InvariantCulture);

            aTriangulo = (A * C) / 2;
            aCirculo = pi * Math.Pow(C, 2);
            aTrapezio = ((A + B) * C) / 2;
            aQuadrado = Math.Pow(B, 2);
            aRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + aTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + aCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + aTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + aQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + aRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}