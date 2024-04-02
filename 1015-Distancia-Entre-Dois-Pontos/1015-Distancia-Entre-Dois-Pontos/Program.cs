using System;
using System.Globalization;

namespace Exercicio1015 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, 
            mostrando 4 casas decimais após a vírgula

            Entrada
            O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1
            e a segunda linha contém dois valores de ponto flutuante x2 y2.
            */

            double distancia, x1, y1, x2, y2, formulaDistancia;
            string[] valoresPontos = Console.ReadLine().Split(' ');

            x1 = double.Parse(valoresPontos[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valoresPontos[1], CultureInfo.InvariantCulture);

            valoresPontos = Console.ReadLine().Split(' ');
            x2 = double.Parse(valoresPontos[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valoresPontos[1], CultureInfo.InvariantCulture);

            formulaDistancia = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            distancia = Math.Sqrt(formulaDistancia);

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}