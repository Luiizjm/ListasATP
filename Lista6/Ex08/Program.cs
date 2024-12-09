/* 
8. Crie um programa que receba dados de vários alunos (Matrícula e Nome) e armazene em um
arquivo texto. Crie no mesmo programa uma função que leia uma matrícula, pesquise no
arquivo e retorne o nome do aluno.
*/

using System;

namespace Ex08
{
    internal class Program
    {
        // Caminho do arquivo onde os dados serão armazenados
        static string caminhoDoArquivo = @"C:\Users\luiiz\Documents\alunos.txt";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Pesquisar aluno pela matrícula");
                Console.WriteLine("3 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAluno();
                        break;
                    case 2:
                        PesquisarAluno();
                        break;
                    case 3:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CadastrarAluno()
        {
            Console.WriteLine("\nDigite a matrícula do aluno:");
            string matricula = Console.ReadLine();

            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            // Armazenar os dados no arquivo (formato: matricula,nome)
            using (StreamWriter writer = new StreamWriter(caminhoDoArquivo, true))
            {
                writer.WriteLine($"{matricula},{nome}");
            }

            Console.WriteLine("Aluno cadastrado com sucesso!");
        }

        static void PesquisarAluno()
        {
            Console.WriteLine("\nDigite a matrícula do aluno que deseja pesquisar:");
            string matriculaProcurada = Console.ReadLine();

            try
            {
                // Ler todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoDoArquivo);

                foreach (string linha in linhas)
                {
                    // Dividir os dados (matrícula e nome)
                    string[] dados = linha.Split(',');

                    if (dados[0] == matriculaProcurada)
                    {
                        Console.WriteLine($"Aluno encontrado: {dados[1]}");
                        return;
                    }
                }

                Console.WriteLine("Matrícula não encontrada.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Erro: O arquivo não foi encontrado. Cadastre um aluno primeiro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
