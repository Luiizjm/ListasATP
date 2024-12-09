/* 

3- Implemente um programa que abra o arquivo texto e conte a quantidade de palavras que 
estão presentes nele. Imprima a quantidade na tela.

*/

using System;
using System.IO;

namespace Ex03
{
    internal class Program
    {
        static void Main()
        {
            // Caminho do arquivo de texto (você pode substituir pelo caminho correto do seu arquivo)
            string caminhoDoArquivo = @"C:\Users\luiiz\Documents\arquivo.txt";

                // Ler o conteúdo do arquivo
                string conteudoDoArquivo = File.ReadAllText(caminhoDoArquivo);

                // Dividir o conteúdo em palavras (separando por espaços, pontuação, etc.)
                string[] palavras = conteudoDoArquivo.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                // Contar o número de palavras
                int quantidadeDePalavras = palavras.Length;

                // Exibir a quantidade de palavras
                Console.WriteLine($"Quantidade de palavras no arquivo: {quantidadeDePalavras}");
        }
    }
}
