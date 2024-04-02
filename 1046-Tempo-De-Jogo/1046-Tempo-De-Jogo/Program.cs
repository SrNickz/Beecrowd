using System;
using System.Globalization;

namespace Exercicio1046 {

    class Program {

        static void Main(string[] args) {
            /*
             Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
             sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

             Entrada
             A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
            */

            int horaInicio, horaFinal, horaTotal;

            string[] horas = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(horas[0]);  
            horaFinal = int.Parse(horas[1]);

            if(horaInicio < horaFinal) {
                horaTotal = horaFinal - horaInicio;
            }
            else {
                horaTotal = 24 - horaInicio + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + horaTotal + " HORA(S)");

        }
    }
}