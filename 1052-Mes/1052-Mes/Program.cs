﻿using System;
using System.Globalization;

namespace Exercicio {

    class Program {

        static void Main(string[] args) {
            /*
            Leia um valor inteiro entre 1 e 12, inclusive. 
            Correspondente a este valor, deve ser apresentado como resposta o mês do ano por extenso, em inglês, com a primeira letra maiúscula.
            */

            int mes = int.Parse(Console.ReadLine());

            if(mes == 1) Console.WriteLine("January");
            else if(mes == 2) Console.WriteLine("February");
            else if(mes == 3) Console.WriteLine("March");
            else if(mes == 4) Console.WriteLine("April");
            else if(mes == 5) Console.WriteLine("May");
            else if(mes == 6) Console.WriteLine("June");
            else if(mes == 7) Console.WriteLine("July");
            else if(mes == 8) Console.WriteLine("August");
            else if(mes == 9) Console.WriteLine("September");
            else if(mes == 10) Console.WriteLine("October");
            else if(mes == 11) Console.WriteLine("November");
            else if(mes == 12) Console.WriteLine("December");
        }
    }
}