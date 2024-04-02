using System;
using System.Globalization;

namespace Exercicio1049 {

    class Program {

        static void Main(string[] args) {
            /*
             Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  
             Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
            */

            string grupo, especie, dieta;
            grupo = Console.ReadLine();
            especie = Console.ReadLine();
            dieta = Console.ReadLine();

            if(grupo == "vertebrado") {
                if(especie == "ave") {
                    if(dieta == "carnivoro") {
                        Console.WriteLine("aguia");
                    }
                    else if(dieta == "onivoro") {
                        Console.WriteLine("pomba");
                    }
                    else Console.WriteLine("Animal invalido");
                }
                else if(especie == "mamifero") {
                    if(dieta == "onivoro") {
                        Console.WriteLine("homem");
                    }
                    else if(dieta == "herbivoro") {
                        Console.WriteLine("vaca");
                    }
                    else Console.WriteLine("Animal invalido");
                }
            }
            else if(grupo == "invertebrado") {
                if(especie == "inseto") {
                    if(dieta == "hematofago") {
                        Console.WriteLine("pulga");
                    }
                    else if(dieta == "herbivoro") {
                        Console.WriteLine("lagarta");
                    }
                    else Console.WriteLine("Animal invalido");
                }
                else if(especie == "anelideo") {
                    if(dieta == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }
                    else if(dieta == "onivoro") {
                        Console.WriteLine("minhoca");
                    }
                }
            }
            else Console.WriteLine("Grupo inválido");
        }
    }
}