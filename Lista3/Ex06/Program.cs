/* 6. Escreva um programa para ler um valor A e um valor N. Imprimir a soma dos N números a
partir de A (inclusive). Caso N seja negativo ou ZERO, deverá ser lido um novo N (apenas N). 
Veja na tabela a seguir algumas entradas para teste. */

using System;

class Program
{
    public static void Main()
    {
        int soma = 0;  // Inicializa a variável que vai acumular a soma.
        int N;  // Declara a variável N, que representará a quantidade de números a serem somados.

        // Solicita ao usuário o valor de A (primeiro número da sequência).
        Console.Write("Digite valor de A: ");
        int A = int.Parse(Console.ReadLine());  // Converte o valor de A para inteiro.

        // Laço para garantir que N seja positivo.
        do
        {
            // Solicita o valor de N e garante que seja positivo.
            Console.WriteLine("Digite o valor de N (deve ser positivo):");
            N = int.Parse(Console.ReadLine());  // Converte o valor de N para inteiro.
        }
        while (N <= 0);  // Se N for negativo ou zero, repete a solicitação.

        // Laço para somar os N números a partir de A.
        for (int i = 0; i < N; i++)
        {
            // A cada iteração, soma o valor de A mais o índice i.
            soma += A + i;
            Console.WriteLine(soma + " | " + i);  // Exibe a soma acumulada e o índice atual para acompanhamento.
        }

        // Exibe o valor total da soma.
        Console.WriteLine("A Soma total é: " + soma);
    }
}
