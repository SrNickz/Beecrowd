using System;
using System.Globalization;

namespace Exercicio1134 {

    class Program {

        static void Main(string[] args) {
            /*
            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
            Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). 
            Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido).
            O programa será encerrado quando o código informado for o número 4.

            Entrada
            A entrada contém apenas valores inteiros e positivos.
            */

            int qtdAlcool, qtdGasolina, qtdDiesel, codCombustivel;

            // Checar cod combustivel
            qtdAlcool = 0;
            qtdGasolina = 0;
            qtdDiesel = 0;

            codCombustivel = int.Parse(Console.ReadLine());
            while(codCombustivel != 4) {
                if(codCombustivel == 1) {
                    qtdAlcool++;
                }
                else if(codCombustivel == 2) {
                    qtdGasolina++;
                }
                else if(codCombustivel == 3) {
                    qtdDiesel++;
                }

                codCombustivel = int.Parse(Console.ReadLine());
            }

            // Console.Clear(); // Limpa o console
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + qtdAlcool);
            Console.WriteLine("Gasolina: " + qtdGasolina);
            Console.WriteLine("Diesel: " + qtdDiesel);
        }
    }
}