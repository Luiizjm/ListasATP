// 3. Faça um programa que calcule e mostre a área de um trapézio. 

using System;

class Program
{
    public static void Main()
    {
        // Solicita ao usuário que insira a base maior do trapézio
        // Usa int.Parse() para converter a string de entrada em um inteiro
        Console.Write("Digite a base maior do Trapézio: ");
        int basemaior = int.Parse(Console.ReadLine());

        // Solicita ao usuário que insira a base menor do trapézio
        Console.Write("Digite a base menor do Trapézio: ");
        int basemenor = int.Parse(Console.ReadLine());

        // Solicita ao usuário que insira a altura do trapézio
        Console.Write("Digite a altura do Trapézio: ");
        int altura = int.Parse(Console.ReadLine());

        // Calcula a área do trapézio usando a fórmula: ((base maior + base menor) * altura) / 2
        // A conversão explícita para double garante a precisão do cálculo
        double area = (double)((basemaior + basemenor) * altura) / 2;

        // Exibe o resultado da área do trapézio
        Console.WriteLine($"A área do trapézio é {area}.");
    }
}