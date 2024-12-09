using System;  // Importa o namespace System, necessário para usar a classe Console.

public class Exercicio3  // Define a classe 'Exercicio3'.
{
    // Método principal que chama o método Vetor.
    public static void Rodar()
    {
        // Chama o método Vetor para executar a lógica do exercício.
        Vetor();
    }

    // Método para criar o vetor, preencher com valores e encontrar o menor valor.
    static void Vetor()
    {
        // Solicita ao usuário que informe o tamanho do vetor.
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());  // Lê o tamanho do vetor informado pelo usuário.

        // Cria o vetor de inteiros com o tamanho fornecido.
        int[] Vet = new int[tamanho];

        // Solicita ao usuário que insira os valores para cada posição do vetor.
        Console.WriteLine("Digite os valores de cada espaço do vetor: ");
        for (int i = 0; i < Vet.Length; i++)  // Laço para preencher o vetor.
        {
            Console.Write("--> ");  // Exibe um prompt para o usuário inserir um valor.
            Vet[i] = int.Parse(Console.ReadLine());  // Lê o valor e armazena no vetor.
        }

        // Chama o método Menor para encontrar a posição do menor valor no vetor.
        int NumMenor = Menor(Vet);

        // Exibe a posição do menor valor e o próprio valor no vetor.
        Console.WriteLine("O Menor valor do vetor está na posição: " + NumMenor);
        Console.WriteLine("Vetor = " + Vet[NumMenor]);
    }

    // Método que retorna a posição do menor valor do vetor.
    static int Menor(int[] Vet) 
    {
        int Posicao = 0;  // Inicializa a variável 'Posicao' com 0, assumindo que o menor valor está na primeira posição.

        // Laço para percorrer o vetor e encontrar a posição do menor valor.
        for (int i = 0; i < Vet.Length; i++)  
        {
            if (Vet[i] < Vet[Posicao])  // Se o valor atual for menor que o valor na posição armazenada.
            {
                Posicao = i;  // Atualiza a posição do menor valor.
            }
        }

        return Posicao;  // Retorna a posição do menor valor.
    }
}
