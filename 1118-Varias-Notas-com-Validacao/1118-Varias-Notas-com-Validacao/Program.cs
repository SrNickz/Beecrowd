using System;
using System.Globalization;

namespace Exercicio1118 {

    class Program {

        static void Main(string[] args) {
            /*
            Escreva um programa para ler as notas da primeira e a segunda avaliação de um aluno. 
            Calcule e imprima a média semestral. O programa só deverá aceitar notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
            Cada nota deve ser validada separadamente.

            No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, 
            solicitando ao usuário que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). 
            Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.

            Entrada
            O arquivo de entrada contém vários valores reais, positivos ou negativos. Quando forem lidas duas notas válidas, deve ser lido um valor inteiro X . 
            O programa deve parar quando o valor lido para este X for igual a 2.
            */

            double nota1, nota2, media;
            int novoCalculo = 1;

            while(novoCalculo == 1) {
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while(nota1 < 0.0 || nota1 > 10.0) {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while(nota2 < 0.0 || nota2 > 10.0) {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
                while(novoCalculo != 1 && novoCalculo != 2) {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}