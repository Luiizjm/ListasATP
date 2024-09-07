/* 7. Fazer um programa que receba os três coeficientes de uma equação do segundo grau e calcule
as suas raízes. Suponha que só serão informadas equações com raízes reais. */

using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o valor do coeficiente 'a' da equação do segundo grau
        // Usa int.Parse() para converter a string de entrada em um valor inteiro
        Console.Write("Digite o valor de a: ");
        int a = int.Parse(Console.ReadLine());

        // Solicita ao usuário que insira o valor do coeficiente 'b' da equação do segundo grau
        Console.Write("Digite o valor de b: ");
        int b = int.Parse(Console.ReadLine());

        // Solicita ao usuário que insira o valor do coeficiente 'c' da equação do segundo grau
        Console.Write("Digite o valor de c: ");
        int c = int.Parse(Console.ReadLine());

        // Calcula o valor de Delta (discriminante) usando a fórmula Delta = b^2 - 4ac
        // Math.Pow(b, 2) calcula b ao quadrado
        double delta = Math.Pow(b, 2) - 4 * a * c;

        // Calcula as raízes da equação do segundo grau usando a fórmula de Bhaskara
        // Raiz 1: (-b + √Delta) / (2a)
        double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);

        // Raiz 2: (-b - √Delta) / (2a)
        double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

        // Exibe o valor de Delta
        Console.WriteLine($"\nValor de Delta: {delta}.");

        // Exibe o valor da primeira raiz
        Console.WriteLine($"Valor da primeira raiz: {raiz1}.");

        // Exibe o valor da segunda raiz
        Console.WriteLine($"Valor da segunda raiz: {raiz2}.");
    }
}