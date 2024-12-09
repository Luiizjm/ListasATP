/* 2 - Faça um programa que receba do usuário uma frase e imprima a frase sem os espaços. */

using System;

namespace Ex02
{
    internal class Program
    {
        static void Main()
        {
            string frase;
            
            // Solicita ao usuário que digite uma frase
            Console.WriteLine("Digite a Frase");
            frase = Console.ReadLine();

            // Verifica se a frase está vazia ou contém apenas espaços
            while(string.IsNullOrWhiteSpace(frase))
            {
                // Exibe uma mensagem de erro e solicita uma nova entrada
                Console.WriteLine("A Frase não pode estar vazia!");
                Console.WriteLine("Digite uma frase: ");
                frase = Console.ReadLine();
            }

            // Remove todos os espaços da frase utilizando o método Replace
            string FraseSemEspaço = frase.Replace(" ","");

            // Exibe a frase original e a versão sem espaços
            Console.WriteLine("Normal: " + frase); // Exibe a frase original
            Console.WriteLine("Sem Espaços: " + FraseSemEspaço); // Exibe a frase sem espaços
        }
    }
}
