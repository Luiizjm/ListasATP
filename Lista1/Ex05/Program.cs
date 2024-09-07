/* 5. Faça um programa que receba o raio, calcule e mostre:
a) o comprimento de uma esfera, sabe-se que C = 2πR;
b) a área de uma esfera, sabe-se que A = πR2;
c) o volume de uma esfera, sabe-se que V = 4/3πR3.
Obs: Para calcular o raio ao quadrado ou ao cubo você pode usar a função Pow() como abaixo:
Z = Math.Pow(x, y) // calcula a potência: XY e coloca o resultado na variável Z. */

using System;

class Program
{
    public static void Main()
    {
        // Solicita ao usuário que insira o valor do raio da esfera
        // Usa double.Parse() para converter a string de entrada em um valor do tipo double
        Console.Write("Digite o raio da esfera: ");
        double raio = double.Parse(Console.ReadLine());

        // Calcula o comprimento da esfera usando a fórmula C = 2πR
        double comprimento = 2 * Math.PI * raio;

        // Calcula a área da esfera usando a fórmula A = 4πR^2
        // Math.Pow() é usado para elevar o raio ao quadrado
        double area = 4 * Math.PI * Math.Pow(raio, 2);

        // Calcula o volume da esfera usando a fórmula V = 4/3πR^3
        // Math.Pow() é usado para elevar o raio ao cubo
        double volume = (4 * Math.PI * Math.Pow(raio, 3)) / 3;

        // Exibe o comprimento da esfera formatado com duas casas decimais
        Console.WriteLine($"Comprimento: {comprimento:F2}.");

        // Exibe a área da esfera formatada com duas casas decimais
        Console.WriteLine($"Área: {area:F2}.");

        // Exibe o volume da esfera formatado com duas casas decimais
        Console.WriteLine($"Volume: {volume:F2}.");
    }
}