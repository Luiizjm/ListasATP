/* 1- Faça um programa para ler uma frase e contar os caracteres iguais à sua inicial.
Obs: Crie um comentário e coloque seu nome completo.

Nome: Luiz Eduardo Jardim de Medeiros */

using System;

namespace Ex01
{
    internal class Program
    {
        static void Main()
        {
            string frase;

            // Solicita ao usuário que digite uma frase
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            // Valida se a frase está vazia ou contém apenas espaços
            while (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine("A Frase não pode estar vazia!"); // Alerta para entrada inválida
                Console.WriteLine("Digite uma frase: "); // Solicita nova entrada
                frase = Console.ReadLine(); // Lê novamente a entrada do usuário
            }

            // Captura o primeiro caractere da frase e converte para minúsculo
            char inicial = char.ToLower(frase[0]);

            // Inicializa o contador de caracteres iguais ao inicial
            int contador = 0;

            // Percorre todos os caracteres da frase
            for (int i = 0; i < frase.Length; i++)
            {
                // Compara o caractere atual (convertido para minúsculo) com o caractere inicial
                if (char.ToLower(frase[i]) == inicial)
                {
                    contador++; // Incrementa o contador se houver correspondência
                }
            }

            // Exibe o resultado: número de caracteres iguais ao inicial
            Console.WriteLine($"A quantidade de caracteres iguais à inicial é: {contador}");
        }
    }
}
