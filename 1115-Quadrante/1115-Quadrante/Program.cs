using System;
using System.Globalization;

namespace Exercicio1115 {

    class Program {

        static void Main(string[] args) {
            /*
             Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. 
             O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

             Entrada
             A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.
            */

            int x, y;

            string[] coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) { // Quadrante 1
                    Console.WriteLine("primeiro");
                } 
                else if (x < 0 && y > 0) { // Quadrante 2
                    Console.WriteLine("segundo");
                }
                else if(x < 0 && y < 0) { // Quadrante 3
                    Console.WriteLine("terceiro");
                }
                else { // Quadrante 4
                    Console.WriteLine("quarto");
                }

                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }
    }
}