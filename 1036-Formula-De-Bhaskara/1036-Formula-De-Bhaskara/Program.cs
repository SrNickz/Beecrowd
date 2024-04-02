using System;
using System.Globalization;

namespace Exercicio1036 {

    class Program {

        static void Main(string[] args) {
            // se não for possível calcular as raizes dizer "Impossível calcular" (Caso exista uma divisão por 0 ou numero negativo na raiz)


            double a, b, c, delta, raiz1, raiz2;

            string[] coeficientes = Console.ReadLine().Split(' ');

            a = double.Parse(coeficientes[0], CultureInfo.InvariantCulture);
            b = double.Parse(coeficientes[1], CultureInfo.InvariantCulture);
            c = double.Parse(coeficientes[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            if(delta >= 0 && a != 0) {
                raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                raiz2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + raiz1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + raiz2.ToString("F5", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
