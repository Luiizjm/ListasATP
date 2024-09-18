/* 1. Escreva um programa que leia um número inteiro do usuário e verifique se ele é positivo,
negativo ou zero. Exiba uma mensagem apropriada para cada caso. */

using System;  // Importa a biblioteca que permite o uso de funções básicas do C#, como a leitura de dados do console.

class Program  // Define a classe "Program" que contém o ponto de entrada do programa.
{
    static void Main()  // Método principal que é executado quando o programa inicia.
    {
        // Exibe uma mensagem pedindo para o usuário inserir um número.
        Console.Write("Digite um número: ");  

        // Lê a entrada do usuário como uma string e a converte para um número inteiro.
        int num = int.Parse(Console.ReadLine());  

        // Verifica se o número é igual a zero.
        if (num == 0)  
            Console.Write($"O número {num} é neutro.");  // Exibe mensagem informando que o número é zero.
        
        // Verifica se o número é maior que zero, ou seja, positivo.
        else if (num > 0)  
            Console.Write($"O número {num} é Positivo.");  // Exibe mensagem informando que o número é positivo.
        
        // Se não for zero nem positivo, o número é negativo.
        else  
            Console.Write($"O número {num} é Negativo.");  // Exibe mensagem informando que o número é negativo.
    }
}
