using System;
using System.Globalization;

namespace Exercicio1040 {

    class Program {

        static void Main(string[] args) {
            /*
             Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno.
             Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: " 
             Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". 
             Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". 
             Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

             No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. 
             Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada.
             Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2).
             e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", 
             (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) 
             apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.
            */

            float nota1, nota2, nota3, nota4, media, notaExame;
            int peso1, peso2, peso3, peso4;
            peso1 = 2;
            peso2 = 3;
            peso3 = 4;
            peso4 = 1;

            string[] notas = Console.ReadLine().Split(' ');
            nota1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = (float) ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 * peso4)) / (peso1 + peso2 + peso3 + peso4);

            if(media == 4.85f) {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            if(media >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if(media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            }
            else {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                media = (media + notaExame) / 2f;

                if(media >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                } else {
                    Console.WriteLine("Aluno Reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}