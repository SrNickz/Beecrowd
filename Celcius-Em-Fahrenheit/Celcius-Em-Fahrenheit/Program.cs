using System;
using System.Globalization;

namespace ExercicioAula51 {

    class Program {

        static void Main(string[] args) {
            /*
             Fazer um programa para ler a temperatura em celsius e mostrar o equivalente
            em fahrenheit. Perguntar se o usuário deseja repetir (s/n). 
            Caso o usuário digite "s", repetir o programa

            Fórmula: F = (9C / 5) + 32
            */

            float F, C;
            string continua;

            do {
                Console.WriteLine("Digite a temperatura em Celsius:");
                C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = ((9f * C) / 5f) + 32f;
                Console.WriteLine("Equivalente em fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));

                Console.WriteLine("Deseja repetir? (s/n)?");
                continua = Console.ReadLine();
                while(continua != "s" && continua != "n") {
                    Console.WriteLine("Digite um parâmetro válido");
                    continua = Console.ReadLine();
                }
            } while(continua == "s");
        }
    }
}