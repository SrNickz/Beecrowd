using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1061 {
    class Program {
        static void Main(string[] args) {

            int initialDay, initialHour, initialMinute, initialSecond,
                finalDay, finalHour, finalMinute, finalSecond;

            int totalDays, totalHours, totalMinutes, totalSeconds;


            // Leio o dia inicial
            Console.Write("Dia ");
            initialDay = int.Parse(Console.ReadLine());

            // Leio o horário do dia inicial
            string[] timeDayOne = Console.ReadLine().Split(" : ");   
            initialHour = int.Parse(timeDayOne[0]);    
            initialMinute = int.Parse(timeDayOne[1]);    
            initialSecond = int.Parse(timeDayOne[2]);

            // Leio o dia final
            Console.Write("Dia ");
            finalDay = int.Parse(Console.ReadLine());

            // Leio o horário do dia final
            string[] timeFinalDay = Console.ReadLine().Split(" : ");
            initialHour = int.Parse(timeFinalDay[0]);
            initialMinute = int.Parse(timeFinalDay[1]);
            initialSecond = int.Parse(timeFinalDay[2]);


        }
    }
}