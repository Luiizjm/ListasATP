/* 
9. Crie um arquivo texto com frases motivacionais. Depois, crie um programa que simule um
sorteio destas frases. O programa deve buscar uma frase aleatoriamente no arquivo e exibir
na tela para o usuário. Além disso, o sistema deve perguntar ao usuário se o mesmo deseja
receber outra frase e repetir o processo caso a resposta seja afirmativa.
*/

using System;


namespace Ex09
{
    internal class Program
    {
        static string caminhoDoArquivo = @"C:\Users\luiiz\Documents\frases.txt";

        static void Main()
        {

            string[] frases = File.ReadAllLines(caminhoDoArquivo);

            if (frases.Length == 0)
            {
                Console.WriteLine("Erro: O arquivo de frases está vazio.");
                return;
            }

            Random random = new Random();
            string resposta;

            do
            {
                // Sorteia uma frase aleatória
                int indice = random.Next(frases.Length);
                Console.WriteLine($"\nFrase sorteada: {frases[indice]}");

                Console.WriteLine("\nDeseja receber outra frase? (s/n):");
                resposta = Console.ReadLine().ToLower();

            } while (resposta == "s");

            Console.WriteLine("\nObrigado por usar o sorteio de frases! Até mais!");
        }
    }
}
