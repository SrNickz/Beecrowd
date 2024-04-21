using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            /*
            Este programa deve ler uma variável inteira X inúmeras vezes (deve parar quando o valor no arquivo de entrada for igual a zero). Para cada valor lido imprima a sequência de 1 até X, com um espaço entre cada número e seu sucessor.

            Obs: cuide para não deixar espaço em branco após o último valor apresentado na linha ou você receberá Presentation Error.

            Entrada
            O arquivo de entrada contém vários números inteiros. O último número no arquivo de entrada é 0.
            */

            int x = int.Parse(Console.ReadLine());
            int i;

            while (x > 0) {
                for (i = 1; i <= x; i++) {
                    if (i != x) Console.Write(i + " ");
                    else Console.Write(i);
                }
                Console.WriteLine();
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}