using System;
using System.Globalization;

namespace Exercicio1038 {

    class Program {

        static void Main(string[] args) {
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
            1 - Cachorro-Quente R$ 4
            2 - X-salada R$ 4.5
            3 - X-bacon R$ 5
            4 - Torrada simples R$ 2
            5 - Refri - R$ 1.5
            */

            int codigo, qtdItem;
            double total, preco;

            string[] informacao = Console.ReadLine().Split(' ');

            codigo = int.Parse(informacao[0]);
            qtdItem = int.Parse(informacao[1]);

            if(codigo == 1) {
                preco = 4.00;
                total = qtdItem * preco;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(codigo == 2) {
                preco = 4.50;
                total = qtdItem * preco;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(codigo == 3) {
                preco = 5.00;
                total = qtdItem * preco;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(codigo == 4) {
                preco = 2.00;
                total = qtdItem * preco;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(codigo == 5) {
                preco = 1.50;
                total = qtdItem * preco;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Código inválido");
            }

        }
    }
}