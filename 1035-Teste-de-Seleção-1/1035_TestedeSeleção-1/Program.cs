using System;
using System.Globalization;

namespace Exercicio1035 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia 4 valores inteiros A, B, C e D. 
            A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos, 
            forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

            Entrada
            Quatro números inteiros A, B, C e D. 
            */

            int a, b, c, d;

            string[] valoresInt = Console.ReadLine().Split(' ');

            a = int.Parse(valoresInt[0]);
            b = int.Parse(valoresInt[1]);
            c = int.Parse(valoresInt[2]);
            d = int.Parse(valoresInt[3]);


            if(b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0) {
                Console.WriteLine("Valores aceitos");
            }
            else {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }


}