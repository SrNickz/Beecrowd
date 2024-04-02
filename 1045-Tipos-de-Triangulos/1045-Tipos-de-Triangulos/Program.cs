using System;
using System.Globalization;

namespace uri1045 {
    class Program {
        static void Main(string[] args) {

            /*
                Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. 
                A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

                se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
                se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
                se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
                se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
                se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
                se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

                Entrada
                A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).
            */

            string[] valores = Console.ReadLine().Split(' ');
            double numero1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double numero2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double numero3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double A, B, C;
            if(numero1 > numero2 && numero1 > numero3) {
                A = numero1;
                if(numero2 > numero3) {
                    B = numero2;
                    C = numero3;
                }
                else {
                    B = numero3;
                    C = numero2;
                }
            }
            else if(numero2 > numero3) {
                A = numero2;
                if(numero1 > numero3) {
                    B = numero1;
                    C = numero3;
                }
                else {
                    B = numero3;
                    C = numero1;
                }
            }
            else {
                A = numero3;
                if(numero1 > numero2) {
                    B = numero1;
                    C = numero2;
                }
                else {
                    B = numero2;
                    C = numero1;
                }
            }

            if(A >= B + C) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                // primeiro vamos testas as tres possibilidades em relacao a angulos
                if(A * A == B * B + C * C) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if(A * A > B * B + C * C) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                // agora vamos testar se pode ser equilatero ou isosceles
                if(A == B && B == C) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if(A == B || A == C || B == C) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}