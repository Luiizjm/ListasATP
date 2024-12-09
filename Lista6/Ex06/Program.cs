/* 
6. Faça um programa que solicite ao usuário um número, em seguida, imprima na tela todos os
seus divisores. Salve em um arquivo texto a soma total desses divisores.
*/

using System;

namespace Ex06
{
    internal class Program
    {
        static void Main()
        {
            // Solicita ao usuário um número
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            // Variável para armazenar a soma dos divisores
            int somaDivisores = 0;

            Console.WriteLine("Divisores do número:");

            // Calcula os divisores do número
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i); // Exibe o divisor na tela
                    somaDivisores += i;  // Adiciona o divisor à soma
                }
            }

            // Caminho para salvar o arquivo de texto
            string caminhoDoArquivo = @"C:\Users\luiiz\Documents\resultado.txt";

            try
            {
                // Salva a soma dos divisores no arquivo texto
                File.WriteAllText(caminhoDoArquivo, $"A soma dos divisores de {numero} é: {somaDivisores}");
                Console.WriteLine($"\nA soma total dos divisores foi salva no arquivo: {caminhoDoArquivo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");
            }
        }
    }
}
