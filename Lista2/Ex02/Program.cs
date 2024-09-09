/* 2. Crie um programa que leia três números inteiros e determine qual é o maior e qual é o menor.
Exiba os resultados. */

using System;

class Program
{
    static void Main()
    {   
        Console.WriteLine("Digite os números A, B e C: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int maior = num1;
        int menor = num1;

        // Definir maior número:
        if (num2 > maior)
        {
            maior = num2;
        }
        else if (num3 > maior)
        {
            maior = num3;
        }

        // Definir menor número: 
        if (num2 < menor)
        {
            menor = num2;
        }
        else if (num3 < menor)
        {
            menor = num3;
        }

        Console.WriteLine();
        Console.WriteLine($"Maior número: {maior}.");
        Console.WriteLine($"Menor número: {menor}.");
    }
}