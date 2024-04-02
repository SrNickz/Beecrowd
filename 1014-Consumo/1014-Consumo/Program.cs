using System;
using System.Globalization;

namespace Exercicio1014 {

    class Program {

        static void Main(string[] args) {
            /*
            Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros). 

            Entrada
            O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km)
            e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
            */

            int distTotal;
            double combustivelGasto, consumoMedio;

            distTotal = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consumoMedio = distTotal / combustivelGasto;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}