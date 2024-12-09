/* 
10. Considere um arquivo texto que armazene números em ponto flutuante em cada uma de suas
linhas. Escreva um programa que determine o valor máximo, o valor mínimo e a média
desses valores armazenados no arquivo. Imprima esses valores na tela.
*/

using System;

namespace Ex10
{
    internal class Program
    {
        static void Main()
        {
            // Caminho do arquivo
            string caminhoDoArquivo = @"C:\Users\luiiz\Documents\numeros.txt";

            try
            {
                // Verificar se o arquivo existe
                if (!File.Exists(caminhoDoArquivo))
                {
                    Console.WriteLine("Erro: O arquivo não foi encontrado.");
                    return;
                }

                // Ler todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoDoArquivo);

                if (linhas.Length == 0)
                {
                    Console.WriteLine("Erro: O arquivo está vazio.");
                    return;
                }

                // Converter as linhas para números em ponto flutuante
                double[] numeros = Array.ConvertAll(linhas, double.Parse);

                // Calcular o valor máximo, mínimo e a média
                double maximo = double.MinValue;
                double minimo = double.MaxValue;
                double soma = 0;

                foreach (double numero in numeros)
                {
                    if (numero > maximo)
                        maximo = numero;

                    if (numero < minimo)
                        minimo = numero;

                    soma += numero;
                }

                double media = soma / numeros.Length;

                // Exibir os resultados
                Console.WriteLine($"Valor Máximo: {maximo}");
                Console.WriteLine($"Valor Mínimo: {minimo}");
                Console.WriteLine($"Média: {media:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: O arquivo contém valores que não são números válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
