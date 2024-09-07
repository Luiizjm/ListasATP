/* 1. Escreva um programa que leia um número inteiro do usuário e verifique se ele é positivo,
negativo ou zero. Exiba uma mensagem apropriada para cada caso. */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num == 0) Console.Write($"O número {num} é neutro.");
        else if (num > 0) Console.Write($"O número {num} é Positivo.");
        else Console.Write($"O número {num} é Negativo.");
    }
}