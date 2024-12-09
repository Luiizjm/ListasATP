using System;

public class Exercicio9
{
    // Método principal que chama as funções para exibir a matriz original e sua transposta
    public static void Rodar()
    {
        // Matriz 3x3 definida com valores específicos
        int[,] matriz = {
            { 1,  2,  3 },
            { 5, -1,  4 },
            { -2, 0, 7 }
        };

        // Exibe a matriz original
        Console.WriteLine("Matriz Original:");
        ExibirMatriz(matriz);

        // Obtém a matriz transposta chamando a função ObterTransposta
        int[,] transposta = ObterTransposta(matriz);

        // Exibe a matriz transposta
        Console.WriteLine("\nMatriz Transposta:");
        ExibirMatriz(transposta);
    }

    // Função para calcular a matriz transposta
    public static int[,] ObterTransposta(int[,] matriz)
    {
        // Obtém o número de linhas e colunas da matriz original
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        // Cria uma nova matriz transposta, com o número de linhas igual ao número de colunas da original, e vice-versa
        int[,] transposta = new int[colunas, linhas];

        // Percorre a matriz original para preencher a transposta
        for (int i = 0; i < linhas; i++)  // Percorre as linhas da matriz original
        {
            for (int j = 0; j < colunas; j++)  // Percorre as colunas da matriz original
            {
                // A posição (i, j) da matriz original vai para a posição (j, i) da matriz transposta
                transposta[j, i] = matriz[i, j];
            }
        }

        // Retorna a matriz transposta
        return transposta;
    }

    // Procedimento para exibir uma matriz no console
    public static void ExibirMatriz(int[,] matriz)
    {
        // Percorre as linhas da matriz
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Percorre as colunas da matriz
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Exibe cada elemento da matriz com um espaçamento de 4 caracteres
                Console.Write($"{matriz[i, j],4}");
            }
            // Após exibir todos os elementos da linha, pula para a próxima linha
            Console.WriteLine();
        }
    }
}
