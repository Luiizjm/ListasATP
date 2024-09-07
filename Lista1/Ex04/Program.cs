/* 4. Faça um programa que receba o valor do salário mínimo atual e o valor do salário de um
funcionário, calcule e mostre a quantidade de salários mínimos que ganha esse funcionário */

using System;

class Program
{
    public static void Main()
    {
        // Declaração das variáveis para armazenar o salário mínimo, o salário do funcionário e a quantidade de salários mínimos
        int salario_min, salario_func, salario_quant;
        
        // Solicita ao usuário que insira o valor do salário mínimo atual
        // Usa int.Parse() para converter a string de entrada em um inteiro
        Console.Write("Digite o valor do salário mínimo atual: ");
        salario_min = int.Parse(Console.ReadLine());

        // Solicita ao usuário que insira o valor do salário do funcionário
        Console.Write("Digite o valor do salário do funcionário: ");
        salario_func = int.Parse(Console.ReadLine());

        // Calcula a quantidade de salários mínimos que o funcionário ganha
        // A divisão inteira é usada, já que o número de salários mínimos é considerado um valor inteiro
        salario_quant = salario_func / salario_min;

        // Exibe o resultado da quantidade de salários mínimos ganhos pelo funcionário
        Console.Write($"A quantidade de salários mínimos ganhos é de: {salario_quant}.");
    }
}