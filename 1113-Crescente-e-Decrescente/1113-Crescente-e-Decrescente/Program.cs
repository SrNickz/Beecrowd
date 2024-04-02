using System;
using System.Globalization;

namespace Exercicio1113 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.

            Entrada
            A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y. A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.
            */

            int x, y;
            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while(x != y) { // Significa y != x também
                if(x > y) {
                    Console.WriteLine("Decrescente");
                }
                else {
                    Console.WriteLine("Crescente");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            } 
        }
    }
}