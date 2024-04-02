using System;
using System.Globalization;

namespace Exercicio1094 {

    class Program {

        static void Main(string[] args) {
            /*
            Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os experimentos de um laboratório o qual ela é responsável. 
            Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.

            Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. 
            Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.

            Entrada
            A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. 
            Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia
            (R:Rato S:Sapo C:Coelho).
            */

            string inicialAnimal;
            int N, i, qtdCoelho, qtdRato, qtdSapo, totalCobaias, qtdAnimais;
            double porcentagemCoelho, porcentagemRato, porcentagemSapo;

            N = int.Parse(Console.ReadLine());
            qtdCoelho = 0;
            qtdRato = 0;
            qtdSapo = 0;
            totalCobaias = 0;

            for(i = 1; i <= N; i++) {
                string[] animais = Console.ReadLine().Split(' ');
                qtdAnimais = int.Parse(animais[0]);
                inicialAnimal = (animais[1]);

                if(inicialAnimal == "C") {
                    qtdCoelho += qtdAnimais;
                }
                else if(inicialAnimal == "R") {
                    qtdRato += qtdAnimais;
                }
                else if(inicialAnimal == "S") {
                    qtdSapo += qtdAnimais;
                }
                totalCobaias += qtdAnimais;
            }
            porcentagemCoelho = (((double) qtdCoelho / totalCobaias)) * 100.0;
            porcentagemRato = ((double) qtdRato / totalCobaias) * 100.0;
            porcentagemSapo = ((double) qtdSapo / totalCobaias) * 100.0;

            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdCoelho);
            Console.WriteLine("Total de ratos: " + qtdRato);
            Console.WriteLine("Total de sapos: " + qtdSapo);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}