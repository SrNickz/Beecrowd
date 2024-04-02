using System;
using System.Globalization;

namespace Exercicio1010 {

    class Program {

        static void Main(string[] args) {
            /*
            Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
            o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

            Entrada
            O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
            */

            int codPeca1, codPeca2, numPeca1, numPeca2;
            double valorPeca1, valorPeca2, totalPagar;

            string[] valores = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(valores[0]);
            numPeca1 = int.Parse(valores[1]);
            valorPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' '); // AO REENTRAR OS VALORES DO ARRAY, OS ANTIGOS SÃO LIVRES PARA RECEBEREM NOVOS VALORES

            codPeca2 = int.Parse(valores[0]);
            numPeca2 = int.Parse(valores[1]);
            valorPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            totalPagar = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);

            Console.WriteLine("TOTAL A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}