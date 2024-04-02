using System;
using System.Globalization;

namespace Exercicio1021 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
            A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. 
            As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

            Entrada
            O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).
            */

            double N;
            int nota, moeda, resto, qtdNotasMoedas;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");
            nota = 100;
            qtdNotasMoedas = resto / (nota * 100);
            Console.WriteLine((double)qtdNotasMoedas + " nota(s) de R$ 100.00");
            resto %= (nota * 100);

            nota = 50;
            qtdNotasMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasMoedas + " nota(s) de R$ 50.00");
            resto %= (nota * 100);

            nota = 20;
            qtdNotasMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasMoedas + " nota(s) de R$ 20.00");
            resto %= (nota * 100);

            nota = 10;
            qtdNotasMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasMoedas + " nota(s) de R$ 10.00");
            resto %= (nota * 100);

            nota = 5;
            qtdNotasMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasMoedas + " nota(s) de R$ 5.00");
            resto %= (nota * 100);

            nota = 2;
            qtdNotasMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasMoedas + " nota(s) de R$ 2.00");
            resto %= (nota * 100);

            // MOEDAS
            Console.WriteLine("MOEDAS:");
            moeda = 100;
            qtdNotasMoedas = resto / moeda;
            Console.WriteLine(qtdNotasMoedas + " moeda(s) de R$ 1.00");
            resto %= moeda;

            moeda = 50;
            qtdNotasMoedas = resto / moeda;
            Console.WriteLine(qtdNotasMoedas + " moeda(s) de R$ 0.50");
            resto %= moeda;

            moeda = 25;
            qtdNotasMoedas = resto / moeda;
            Console.WriteLine(qtdNotasMoedas + " moeda(s) de R$ 0.25");
            resto %= moeda;

            moeda = 10;
            qtdNotasMoedas = resto / moeda;
            Console.WriteLine(qtdNotasMoedas + " moeda(s) de R$ 0.10");
            resto %= moeda;

            moeda = 5;
            qtdNotasMoedas = resto / moeda;
            Console.WriteLine(qtdNotasMoedas + " moeda(s) de R$ 0.05");
            resto %= moeda;

            moeda = 1;
            qtdNotasMoedas = resto / moeda;
            Console.WriteLine(qtdNotasMoedas + " moeda(s) de R$ 0.01");
            resto %= moeda;
        }
    }
}
