/* 2. Crie um programa que leia três números inteiros e determine qual é o maior e qual é o menor.
Exiba os resultados. */

using System;  // Importa a biblioteca necessária para funções básicas do C#, como leitura de dados do console.

class Program  // Define a classe "Program" que contém o ponto de entrada do programa.
{
    static void Main()  // Método principal que é executado quando o programa inicia.
    {
        // Exibe uma mensagem pedindo ao usuário para inserir três números.
        Console.WriteLine("Digite os números A, B e C: ");
        
        // Lê os três números do usuário como strings e os converte para inteiros.
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        // Inicializa as variáveis 'maior' e 'menor' com o valor do primeiro número.
        int maior = num1;
        int menor = num1;

        // Verifica se o segundo número é maior que o valor atual de 'maior'.
        if (num2 > maior)
        {
            maior = num2;  // Atualiza 'maior' se o segundo número for maior.
        }
        else if (num3 > maior)  // Caso contrário, verifica se o terceiro número é maior.
        {
            maior = num3;  // Atualiza 'maior' se o terceiro número for maior.
        }

        // Verifica se o segundo número é menor que o valor atual de 'menor'.
        if (num2 < menor)
        {
            menor = num2;  // Atualiza 'menor' se o segundo número for menor.
        }
        else if (num3 < menor)  // Caso contrário, verifica se o terceiro número é menor.
        {
            menor = num3;  // Atualiza 'menor' se o terceiro número for menor.
        }

        // Exibe os resultados do maior e menor número.
        Console.WriteLine();
        Console.WriteLine($"Maior número: {maior}.");  // Exibe o maior número.
        Console.WriteLine($"Menor número: {menor}.");  // Exibe o menor número.
    }
}
