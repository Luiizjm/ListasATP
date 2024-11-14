using System;

public class Exercicio3
{
    public static void Rodar()
    {
        Vetor();
    }

    static void Vetor()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] Vet = new int[tamanho];

        Console.WriteLine("Digite os valores de cada espaço do vetor: ");
        for(int i = 0; i < Vet.Length; i++)
        {
            Console.Write("--> ");
            Vet[i] = int.Parse(Console.ReadLine());
        }

        int NumMenor = Menor(Vet);

        Console.WriteLine("O Menor valor do vetor está na posição: " + NumMenor);
        Console.WriteLine("Vetor = " + Vet[NumMenor]);
    }

    static int Menor(int[] Vet) 
    {
        int Posicao = 0;

        for (int i = 0; i < Vet.Length; i++)
        {
            if (Vet[i] < Vet[Posicao])
            {
                Posicao = i;
            }
        }

        return Posicao;
    }
}