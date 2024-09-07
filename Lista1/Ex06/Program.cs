/* 6. Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e mostre a
medida do terceiro ângulo. Sabe-se que a soma dos ângulos de um triângulo é 180. */

using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o valor do primeiro ângulo do triângulo
        // Usa float.Parse() para converter a string de entrada em um valor do tipo float
        Console.Write("Digite o primeiro ângulo: ");
        float angulo1 = float.Parse(Console.ReadLine());

        // Solicita ao usuário que insira o valor do segundo ângulo do triângulo
        Console.Write("Digite o segundo ângulo: ");
        float angulo2 = float.Parse(Console.ReadLine());

        // Calcula o valor do terceiro ângulo do triângulo
        // Sabendo que a soma dos ângulos internos de um triângulo é sempre 180 graus
        float angulo3 = 180 - (angulo1 + angulo2);

        // Exibe o valor do terceiro ângulo
        Console.Write($"A medida do terceiro ângulo é de {angulo3}.");
    }
}