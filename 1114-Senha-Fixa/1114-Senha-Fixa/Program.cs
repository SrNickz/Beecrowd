using System;
using System.Globalization;

namespace Exercicio1114 {

    class Program {

        static void Main(string[] args) {
            /*
            Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
            Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 

            Entrada
            A entrada é composta por vários casos de testes contendo valores inteiros.
            */

            int senha, senhaEntrada;
            senha = 2002;
            senhaEntrada = int.Parse(Console.ReadLine());

            while(senhaEntrada != senha) {
                Console.WriteLine("Senha Invalida");
                senhaEntrada = int.Parse(Console.ReadLine());
            }

            if(senhaEntrada == senha) {
                Console.WriteLine("Acesso Permitido");
            }
        }
    }
}