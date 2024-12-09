/* 
5- Implemente um programa que leia um arquivo texto e imprima, linha a linha, o seu conteúdo 
na tela. Imprima também a quantidade de linhas que este arquivo possui.
*/

using System;

namespace Ex05
{
    internal class Program
    {
        static void Main()
        {
            // Caminho do arquivo (substitua com o caminho do seu arquivo de texto)
            string caminhoDoArquivo = @"C:\Users\luiiz\Documents\ex05.txt";

                // Ler todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoDoArquivo);

                // Contar o número de linhas
                int quantidadeDeLinhas = linhas.Length;

                // Imprimir o conteúdo linha por linha
                Console.WriteLine("Conteúdo do arquivo:");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }

                // Imprimir a quantidade de linhas
                Console.WriteLine($"\nQuantidade de linhas no arquivo: {quantidadeDeLinhas}");
        }
    }
}
