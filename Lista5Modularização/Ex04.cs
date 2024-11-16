using System;  // Importa o namespace System, necessário para usar a classe Console.

public class Exercicio4  // Define a classe 'Exercicio4'.
{
    // Método principal que chama os métodos para preencher, intercalar e exibir os vetores.
    public static void Rodar()
    {
        // Criação dos vetores X, Y e VetRes.
        int[] X = new int[10];  // Vetor X com 10 elementos.
        int[] Y = new int[10];  // Vetor Y com 10 elementos.
        int[] VetRes = new int[20];  // Vetor resultante com 20 elementos (tamanho de X + Y).

        // Chama o método para preencher os vetores X e Y.
        PreencherVetores(X, Y);

        // Chama o método para intercalar os vetores X e Y no vetor VetRes.
        IntercalarVetores(X, Y, VetRes);

        // Chama o método para exibir o vetor resultante (VetRes).
        ExibirVetor(VetRes);
    }

    // Método para preencher os vetores X e Y com valores fornecidos pelo usuário.
    static void PreencherVetores(int[] X, int[] Y)
    {
        // Solicita ao usuário os valores para o vetor X.
        Console.WriteLine("Digite os valores do vetor X:");
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = int.Parse(Console.ReadLine());  // Lê um valor e armazena no vetor X.
        }

        // Solicita ao usuário os valores para o vetor Y.
        Console.WriteLine("Digite os valores do vetor Y:");
        for (int i = 0; i < Y.Length; i++)
        {
            Y[i] = int.Parse(Console.ReadLine());  // Lê um valor e armazena no vetor Y.
        }
    }

    // Método para intercalar os vetores X e Y no vetor VetRes.
    static void IntercalarVetores(int[] X, int[] Y, int[] VetRes)
    {
        // Laço para intercalar os valores dos vetores X e Y no vetor VetRes.
        for (int i = 0; i < X.Length; i++)
        {
            VetRes[i * 2] = X[i];     // Coloca os elementos de X nas posições ímpares (0, 2, 4, ..., 18) de VetRes.
            VetRes[i * 2 + 1] = Y[i]; // Coloca os elementos de Y nas posições pares (1, 3, 5, ..., 19) de VetRes.
        }
    }

    // Método para exibir os elementos do vetor VetRes.
    static void ExibirVetor(int[] VetRes)
    {
        // Exibe uma mensagem indicando que o vetor resultante será mostrado.
        Console.WriteLine("Vetor intercalado:");

        // Laço para exibir cada elemento do vetor VetRes.
        for (int i = 0; i < VetRes.Length; i++)
        {
            // Exibe o índice e o valor correspondente do vetor VetRes.
            Console.WriteLine($"[{i}] --> {VetRes[i]}");
        }
    }
}
