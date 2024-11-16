using System;

public class Exercicio8
{
    // Método principal que chama os outros métodos e exibe os resultados
    public static void Rodar()
    {
        // Cria uma matriz 5x5 de inteiros
        int[,] matriz = new int[5, 5];

        // Preenche a matriz com valores aleatórios entre 1 e 50
        PreencherMatriz(matriz);

        // Exibe a matriz gerada
        Console.WriteLine("Matriz gerada:");
        ExibirMatriz(matriz);

        // Exibe o resultado da soma de diferentes partes da matriz
        Console.WriteLine($"\nSoma da linha 3: {SomaLinha(matriz, 3)}");
        Console.WriteLine($"Soma da coluna 2: {SomaColuna(matriz, 2)}");
        Console.WriteLine($"Soma da diagonal principal: {SomaDiagonalPrincipal(matriz)}");
        Console.WriteLine($"Soma da diagonal secundária: {SomaDiagonalSecundaria(matriz)}");
        Console.WriteLine($"Soma de todos os elementos da matriz: {SomaTodosElementos(matriz)}");
    }

    // Método para preencher a matriz com valores aleatórios entre 1 e 50
    static void PreencherMatriz(int[,] matriz)
    {
        // Cria um objeto Random para gerar números aleatórios
        Random random = new Random();

        // Preenche cada posição da matriz com um número aleatório entre 1 e 50
        for (int i = 0; i < matriz.GetLength(0); i++)  // Percorre cada linha
        {
            for (int j = 0; j < matriz.GetLength(1); j++)  // Percorre cada coluna
            {
                matriz[i, j] = random.Next(1, 51);  // Gera um número entre 1 e 50
            }
        }
    }

    // Método para exibir a matriz no console de forma formatada
    static void ExibirMatriz(int[,] matriz)
    {
        // Percorre as linhas da matriz
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Percorre as colunas da matriz
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Exibe cada valor da matriz com espaçamento de 4 caracteres
                Console.Write($"{matriz[i, j],4}");
            }
            // Depois de exibir todos os valores da linha, pula para a próxima linha
            Console.WriteLine();
        }
    }

    // Método para calcular a soma de uma linha específica da matriz
    static int SomaLinha(int[,] matriz, int linha)
    {
        int soma = 0;  // Variável para armazenar a soma dos elementos da linha

        // Percorre todas as colunas da linha especificada
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            soma += matriz[linha, j];  // Soma os valores da linha
        }

        // Retorna a soma calculada
        return soma;
    }

    // Método para calcular a soma de uma coluna específica da matriz
    static int SomaColuna(int[,] matriz, int coluna)
    {
        int soma = 0;  // Variável para armazenar a soma dos elementos da coluna

        // Percorre todas as linhas da coluna especificada
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, coluna];  // Soma os valores da coluna
        }

        // Retorna a soma calculada
        return soma;
    }

    // Método para calcular a soma dos elementos da diagonal principal da matriz
    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;  // Variável para armazenar a soma dos elementos da diagonal principal

        // Percorre a diagonal principal (onde os índices da linha e coluna são iguais)
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, i];  // Soma os elementos da diagonal principal
        }

        // Retorna a soma calculada
        return soma;
    }

    // Método para calcular a soma dos elementos da diagonal secundária da matriz
    static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;  // Variável para armazenar a soma dos elementos da diagonal secundária

        // Obtém o tamanho da matriz (assumindo que a matriz é quadrada)
        int n = matriz.GetLength(0);

        // Percorre a diagonal secundária (onde os índices da linha e coluna somam n-1)
        for (int i = 0; i < n; i++)
        {
            soma += matriz[i, n - i - 1];  // Soma os elementos da diagonal secundária
        }

        // Retorna a soma calculada
        return soma;
    }

    // Método para calcular a soma de todos os elementos da matriz
    static int SomaTodosElementos(int[,] matriz)
    {
        int soma = 0;  // Variável para armazenar a soma de todos os elementos

        // Percorre todas as linhas da matriz
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Percorre todas as colunas da matriz
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];  // Soma todos os valores da matriz
            }
        }

        // Retorna a soma total dos elementos
        return soma;
    }
}
