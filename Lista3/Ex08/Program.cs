/*
8 - Faça um algoritmo para ler dois inteiros positivos e calcular o MDC (Máximo Divisor
Comum) e o MMC (Mínimo Múltiplo Comum) entre eles e escrever na tela. */

using System;

class Program
{
    public static void Main()
    {
        Console.Write("Digite o primeiro numero: ");
        int num1 = int.Parse(Console.ReadLine()); // Lê o primeiro número

        Console.Write("Digite o segundo numero: ");
        int num2 = int.Parse(Console.ReadLine()); // Lê o segundo número

        int mdc = 1; // Inicializa o MDC
        int min = Math.Min(num1, num2); // Encontra o menor dos dois números

        // Loop para encontrar o MDC
        for (int i = 1; i <= min; i++)
        {
            if (num1 % i == 0 && num2 % i == 0) // Verifica se i é divisor comum
            {
                mdc = i; // Atualiza o MDC
            }
        }

        int mmc = (num1 * num2) / mdc; // Calcula o MMC utilizando o MDC

        // Exibe os resultados do MDC e MMC
        Console.WriteLine($"MDC de {num1} e {num2} é: {mdc}");
        Console.WriteLine($"MMC de {num1} e {num2} é: {mmc}");
    }
}