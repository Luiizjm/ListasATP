using System;

public class Exercicio10
{
    // Método principal que chama as funções para manipular e exibir a matriz
    public static void Rodar()
    {
        // Criação de uma matriz 10x10
        int[,] matriz = new int[10, 10];

        // Preenche a matriz com valores aleatórios e exibe a matriz original
        PreencherMatriz(matriz);
        Console.WriteLine("Matriz Original:");
        ExibirMatriz(matriz);

        // Realiza a troca das linhas e exibe o resultado
        TrocarLinhas(matriz, 2, 8);
        Console.WriteLine("\nMatriz após troca da linha 2 com a linha 8:");
        ExibirMatriz(matriz);

        // Realiza a troca das colunas e exibe o resultado
        TrocarColunas(matriz, 4, 10);
        Console.WriteLine("\nMatriz após troca da coluna 4 com a coluna 10:");
        ExibirMatriz(matriz);

        // Realiza a troca das diagonais e exibe o resultado
        TrocarDiagonais(matriz);
        Console.WriteLine("\nMatriz após troca da diagonal principal com a diagonal secundária:");
        ExibirMatriz(matriz);
    }

    // Procedimento para preencher a matriz com valores aleatórios entre 1 e 100
    static void PreencherMatriz(int[,] matriz)
    {
        Random random = new Random();  // Cria um gerador de números aleatórios
        for (int i = 0; i < matriz.GetLength(0); i++)  // Percorre as linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++)  // Percorre as colunas
            {
                matriz[i, j] = random.Next(1, 101);  // Atribui um número aleatório entre 1 e 100
            }
        }
    }

    // Procedimento para exibir a matriz no console
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)  // Percorre as linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++)  // Percorre as colunas
            {
                // Exibe cada elemento da matriz com um espaçamento de 4 caracteres
                Console.Write($"{matriz[i, j],4}");
            }
            Console.WriteLine();  // Pula para a próxima linha após exibir uma linha completa
        }
    }

    // Procedimento para trocar duas linhas na matriz
    static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
    {
        linha1--;  // Ajusta para índice baseado em zero
        linha2--;  // Ajusta para índice baseado em zero

        for (int j = 0; j < matriz.GetLength(1); j++)  // Percorre as colunas da matriz
        {
            // Realiza a troca dos elementos nas duas linhas
            int temp = matriz[linha1, j];  // Guarda o valor temporariamente
            matriz[linha1, j] = matriz[linha2, j];  // Troca o valor da linha1 com o da linha2
            matriz[linha2, j] = temp;  // Completa a troca com o valor guardado
        }
    }

    // Procedimento para trocar duas colunas na matriz
    static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
    {
        coluna1--;  // Ajusta para índice baseado em zero
        coluna2--;  // Ajusta para índice baseado em zero

        for (int i = 0; i < matriz.GetLength(0); i++)  // Percorre as linhas da matriz
        {
            // Realiza a troca dos elementos nas duas colunas
            int temp = matriz[i, coluna1];  // Guarda o valor temporariamente
            matriz[i, coluna1] = matriz[i, coluna2];  // Troca o valor da coluna1 com o da coluna2
            matriz[i, coluna2] = temp;  // Completa a troca com o valor guardado
        }
    }

    // Procedimento para trocar a diagonal principal com a diagonal secundária
    static void TrocarDiagonais(int[,] matriz)
    {
        int n = matriz.GetLength(0);  // Obtém o tamanho da matriz (assume-se que a matriz seja quadrada)
        
        for (int i = 0; i < n; i++)  // Percorre as linhas e colunas ao longo das diagonais
        {
            // Realiza a troca dos elementos das diagonais
            int temp = matriz[i, i];  // Guarda o valor da diagonal principal
            matriz[i, i] = matriz[i, n - i - 1];  // Troca com o valor da diagonal secundária
            matriz[i, n - i - 1] = temp;  // Completa a troca com o valor guardado
        }
    }
}
