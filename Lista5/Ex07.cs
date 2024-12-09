using System;

public class Exercicio7
{
    public static void Rodar()
    {
        // Inicializa uma matriz 3x3
        int[,] matriz = new int[3, 3];
        // Preenche a matriz com números aleatórios
        PreencherMatriz(matriz);

        // Exibe a matriz gerada no console
        Console.WriteLine("Matriz gerada:");
        ExibirMatriz(matriz);

        // Encontra os números primos e soma as posições onde eles estão
        int somaPosicoes = EncontrarPrimos(matriz);

        // Exibe a soma das posições dos números primos
        Console.WriteLine($"\nSoma das posições dos números primos: {somaPosicoes}");
    }

    // Preenche a matriz com números aleatórios entre 1 e 30
    static void PreencherMatriz(int[,] matriz)
    {
        Random random = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++) // Para cada linha
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Para cada coluna
            {
                // Preenche a posição com um número aleatório entre 1 e 30
                matriz[i, j] = random.Next(1, 31);
            }
        }
    }

    // Exibe a matriz no console
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) // Para cada linha
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Para cada coluna
            {
                // Exibe o número com uma largura de 4 caracteres
                Console.Write($"{matriz[i, j],4}");
            }
            // Após cada linha, pula para a próxima linha
            Console.WriteLine();
        }
    }

    // Encontra os números primos na matriz e soma as posições (linha + coluna)
    static int EncontrarPrimos(int[,] matriz)
    {
        int somaPosicoes = 0;

        // Exibe os números primos encontrados
        Console.WriteLine("\nNúmeros primos encontrados:");
        for (int i = 0; i < matriz.GetLength(0); i++) // Para cada linha
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Para cada coluna
            {
                if (EhPrimo(matriz[i, j])) // Verifica se o número é primo
                {
                    // Exibe o número primo e sua posição
                    Console.WriteLine($"Primo: {matriz[i, j]} na posição ({i}, {j})");
                    // Soma as posições (linha + coluna)
                    somaPosicoes += i + j;
                }
            }
        }

        // Retorna a soma das posições
        return somaPosicoes;
    }

    // Função para verificar se um número é primo
    static bool EhPrimo(int numero)
    {
        if (numero <= 1) return false; // Números menores ou iguais a 1 não são primos

        // Verifica se o número é divisível por qualquer número entre 2 e a raiz quadrada do número
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false; // Se for divisível, não é primo
        }

        return true; // Se não for divisível por nenhum número, é primo
    }
}
