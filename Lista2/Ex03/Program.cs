/* 3. Escreva um programa que leia um ano e verifique se ele é bissexto. Um ano é bissexto se for
divisível por 4, mas não por 100, exceto se for divisível por 400. */

using System;  // Importa a biblioteca necessária para funções básicas do C#, como a leitura de dados do console.

class Program  // Define a classe "Program" que contém o ponto de entrada do programa.
{
    static void Main()  // Método principal que é executado quando o programa inicia.
    {
        // Exibe uma mensagem pedindo ao usuário para inserir um ano.
        Console.WriteLine("Digite um ano e descubra se é Bissexto: ");
        
        // Lê o ano fornecido pelo usuário como uma string e o converte para um número inteiro.
        int ano = int.Parse(Console.ReadLine());

        // Verifica se o ano é bissexto de acordo com as regras:
        // 1) O ano deve ser divisível por 4.
        // 2) O ano não pode ser divisível por 100, exceto se for divisível por 400.
        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))  
        {
            // Se o ano for bissexto, exibe uma mensagem afirmando isso.
            Console.WriteLine($"O Ano {ano} é Bissexto.");
        }
        else  
        {
            // Caso contrário, exibe uma mensagem informando que o ano não é bissexto.
            Console.WriteLine($"O Ano {ano} não é Bissexto.");
        }
    }
}
