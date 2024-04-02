using System;
using System.Globalization;

namespace Exercicio1037 {

    class Program {

        static void Main(string[] args) {
            /*
            Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) 
            este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            O símbolo ( representa "maior que". Por exemplo:
            [0,25]  indica valores entre 0 e 25.0000, inclusive eles.
            (25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000
            */

            double valor;
            string intervalo;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(valor >= 0 && valor <= 25) {
                intervalo = "[0,25]";
                Console.WriteLine("Intervalo " + intervalo);
            } 
            else if(valor > 25 && valor <= 50) {
                intervalo = "(25,50]";
                Console.WriteLine("Intervalo " + intervalo);
            }
            else if(valor > 50 && valor <= 75) {
                intervalo = "(50,75]";
                Console.WriteLine("Intervalo " + intervalo);
            }
            else if(valor > 75 && valor <= 100) {
                intervalo = "(75,100]";
                Console.WriteLine("Intervalo " + intervalo);
            }
            else {
                Console.WriteLine("Fora de intervalo");    
            }

            Console.ReadLine();
        }
    }
}