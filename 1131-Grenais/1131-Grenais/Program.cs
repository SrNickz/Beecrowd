using System;
using System.Globalization;

namespace Exercicio1131 {

    class Program {

        static void Main(string[] args) {
            /*
            A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. 
            Escreva um programa para ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta.
            Se a resposta for 1, o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, caso contrário deve ser encerrado imprimindo:

            - Quantos GRENAIS fizeram parte da estatística.
            - O número de vitórias do Inter.
            - O número de vitórias do Grêmio.
            - O número de Empates.
            - Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado).

            Entrada
            O arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Grêmio respectivamente. Em seguida háverá um inteiro (1 ou 2), correspondente à 
            repetição do programa.
            */
            string[] gols;
            string quemGanhou;
            int golsInter, golsGremio, qtdGrenais, vitInter, vitGremio, empates, novoGrenal;

            qtdGrenais = 0;
            empates = 0;
            vitInter = 0;
            vitGremio = 0;

            novoGrenal = 1;
            while(novoGrenal == 1) {
                gols = Console.ReadLine().Split(' ');

                golsInter = int.Parse(gols[0]);
                golsGremio = int.Parse(gols[1]);
                qtdGrenais++;

                if(golsInter > golsGremio) {
                    vitInter++;
                }
                else if(golsInter < golsGremio) {
                    vitGremio++;
                }
                else {
                    empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

                while(novoGrenal != 1 && novoGrenal != 2) {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    novoGrenal = int.Parse(Console.ReadLine());
                }
            }

            if(vitInter > vitGremio) {
                quemGanhou = "Inter";
            }
            else if(vitInter < vitGremio) {
                quemGanhou = "Gremio";
            }
            else {
                quemGanhou = "Nao houve vencedor";
            }

            Console.WriteLine(qtdGrenais + " grenais");
            Console.WriteLine("Inter:" + vitInter);
            Console.WriteLine("Gremio:" + vitGremio);
            Console.WriteLine("Empates:" + empates);
            if(quemGanhou != "Nao houve vencedor") {
                Console.WriteLine(quemGanhou + " venceu mais");
            }
            else {
                Console.WriteLine(quemGanhou);
            }
        }
    }
}