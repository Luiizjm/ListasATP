/* 
7- Faça um programa para inserir N letras informadas pelo usuário em um arquivo texto. Onde 
N é uma quantidade de letras definida pelo usuário. Depois de inseridas as N letras, o
programa deverá ler todas as N letras do arquivo, calcular e mostrar a quantidade de vogais,
ou seja, quantas letras a, e, i, o, u.
*/

using System;

namespace Ex07
{
    internal class Program
    {
        static void Main()
        {
            // Solicitar o número de letras a serem inseridas
            Console.WriteLine("Quantas letras você deseja inserir?");
            int n = int.Parse(Console.ReadLine());

            // Caminho do arquivo onde as letras serão salvas
            string caminhoDoArquivo = @"C:\Users\luiiz\Documents\letras.txt";

            // Criar ou limpar o arquivo para adicionar novas letras
            using (StreamWriter writer = new StreamWriter(caminhoDoArquivo))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Digite a letra {i + 1}:");
                    string letra = Console.ReadLine();

                    // Validar se é apenas uma letra
                    if (!string.IsNullOrEmpty(letra) && letra.Length == 1 && char.IsLetter(letra[0]))
                    {
                        writer.Write(letra.ToLower()); // Salva a letra em minúsculo
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, insira apenas uma letra.");
                        i--; // Repetir a entrada para letras inválidas
                    }
                }
            }

            try
            {
                // Ler o conteúdo do arquivo
                string conteudo = File.ReadAllText(caminhoDoArquivo);

                // Contar as vogais
                int quantidadeDeVogais = 0;
                foreach (char c in conteudo)
                {
                    if ("aeiou".Contains(c))
                    {
                        quantidadeDeVogais++;
                    }
                }

                // Exibir as informações
                Console.WriteLine("\nLetras inseridas no arquivo:");
                Console.WriteLine(conteudo);
                Console.WriteLine($"\nQuantidade de vogais: {quantidadeDeVogais}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
