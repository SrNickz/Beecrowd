using System;
using System.Globalization;

namespace Exercicio1047 {

    class Program {

        static void Main(string[] args) {
            /*
             Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

            Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

            Entrada
            Quatro números inteiros representando a hora de início e fim do jogo
            */

            int horaInicial, minInicial, horaFinal, minFinal, totalMin, totalHora;

            string[] valores = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(valores[0], CultureInfo.InvariantCulture);
            minInicial = int.Parse(valores[1], CultureInfo.InvariantCulture);
            horaFinal = int.Parse(valores[2], CultureInfo.InvariantCulture);
            minFinal = int.Parse(valores[3], CultureInfo.InvariantCulture);

            int instanteInicial = horaInicial * 60 + minInicial; // Transformo as horas em minutos
            int instanteFinal = horaFinal * 60 + minFinal; // Transformo as horas em minutos

            int duracao;
            if(instanteInicial < instanteFinal) {
                duracao = instanteFinal - instanteInicial;
            }
            else {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMin = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMin + " MINUTO(S)");
        }
    }
}
