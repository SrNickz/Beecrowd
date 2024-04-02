using System;
using System.Globalization;

namespace Exercicio1041 {

    class Program {

        static void Main(string[] args) {
            /*
             Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
             A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

             Entrada
             Se o ponto estiver na origem, escreva a mensagem “Origem”.
             Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
            */

            float x, y;

            string[] eixo = Console.ReadLine().Split(' ', ';');

            x = float.Parse(eixo[0]);
            y = float.Parse(eixo[1]);

            if (x == 0f && y == 0f) {
                Console.WriteLine("Origem");
            }
            else if (x == 0f) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0f) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0f && y > 0f) {
                Console.WriteLine("Q1"); // Quadrante 1 é o quadrante onde ambos os valores dos eixos são positivos, ou seja: x > 0 ; y > 0.
            }
            else if (x < 0f && y > 0f) {
                Console.WriteLine("Q2"); // Quadrante 2 é o quadrante onde x é negativo, porém y é positivo, ou seja: x < 0 ; y > 0.
            }
            else if (x < 0f && y < 0f) {
                Console.WriteLine("Q3");  // Quadrante 3 é o quadrante onde os dois eixos são negativos, ou seja: x < 0 ; y < 0.
            }
            else {
                Console.WriteLine("Q4"); // Quadrante 4 é o quadrante onde os dois eixos são negativos ou seja: x < 0 ; y < 0.
            }
        }  
    }
}