using System;
using System.Globalization;

namespace Exercicio1004 {

    class Program {

        static void Main(string[] args) {
            /*
            Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   

            Entrada
            O arquivo de entrada contém 2 valores inteiros.
            */
            int num1, num2, prod;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            prod = num1 * num2;

            Console.WriteLine("PROD = " + prod);
        }
    }
}
