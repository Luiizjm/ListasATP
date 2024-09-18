/* 4. Desenvolva um programa que receba a idade de uma pessoa e exiba a categoria dela com
base na idade: "Criança" (0-12), "Adolescente" (13-17), "Adulto" (18-64) ou "Idoso" (65+) */

using System;  // Importa a biblioteca necessária para funções básicas do C#, como a leitura de dados do console.

class Program  // Define a classe "Program" que contém o ponto de entrada do programa.
{
    static void Main()  // Método principal que é executado quando o programa inicia.
    {
        // Exibe uma mensagem pedindo ao usuário para inserir sua idade.
        Console.Write("Digite sua idade: ");
        
        // Lê a idade fornecida pelo usuário como uma string e a converte para um número inteiro.
        int idade = int.Parse(Console.ReadLine());

        // Verifica a categoria de acordo com a idade inserida.
        if (idade <= 12)  
        {
            // Se a idade for de 0 a 12, classifica como "Criança".
            Console.WriteLine($"Você é criança!");
        }
        else if (idade <= 17)  
        {
            // Se a idade for de 13 a 17, classifica como "Adolescente".
            Console.WriteLine($"Você é Adolescente!");
        }
        else if (idade <= 64)  
        {
            // Se a idade for de 18 a 64, classifica como "Adulto".
            Console.WriteLine($"Você é Adulto!");
        }
        else  
        {
            // Se a idade for 65 ou mais, classifica como "Idoso".
            Console.WriteLine($"Você é Idoso!");
        }
    }
}
