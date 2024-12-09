using System;

public class Exercicio1
{
    public static void Rodar()
    {
        int[] vetor = new int[15];

        // Preenche todo o vetor com números inseridos pelo usuário
        for (int i = 0; i < 15; i++)
        {
            Console.Write(i + " - Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Obtém o vetor com os elementos nas posições pares
        int[] pares = idPares(vetor);

        // Exibe o vetor com os elementos das posições pares
        Console.WriteLine("Números nas posições pares:");
        for(int i = 0; i < 8; i++)
        {
            Console.WriteLine(pares[i]);
        }
    }

    // Função que retorna um novo vetor apenas com os elementos nas posições pares
    public static int[] idPares(int[] vetor)
    {
        int[] VetPares = new int[8]; // Apenas 8 elementos (índices 0, 2, 4, ..., 14 são pares)
        int aux= 0;

        for (int i = 0; i < 15; i += 2) // Incrementa de 2 em 2 para pegar só posições pares
        {
            VetPares[aux] = vetor[i];
            aux++;
        }

        return VetPares;
    }
}
