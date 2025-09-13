using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercicio1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                bool isPrime = true;
                int testNumber = int.Parse(Console.ReadLine());

                for (int j = 2; j < testNumber; j++)
                {
                    if (testNumber % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime == true)
                {
                    Console.WriteLine(testNumber + " eh primo");
                }
                else
                {
                    Console.WriteLine(testNumber + " nao eh primo");
                }
            }
        }
    }
}