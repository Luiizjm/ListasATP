using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio4  // Define a classe 'Exercicio4'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        // Solicita ao usuário que digite o primeiro número.
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());  // Lê e converte o valor digitado para um inteiro.

        // Solicita ao usuário que digite o segundo número.
        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());  // Lê e converte o segundo valor digitado para um inteiro.

        // Chama o método CalcularMDC para calcular o máximo divisor comum (MDC) dos dois números.
        int mdc = CalcularMDC(a, b);

        // Exibe o resultado do MDC.
        Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");
    }

    // Método que calcula o máximo divisor comum (MDC) usando o algoritmo de Euclides.
    static int CalcularMDC(int a, int b)
    {
        // Enquanto b não for zero, continue o cálculo do MDC.
        while (b != 0)
        {
            int resto = a % b;  // Calcula o resto da divisão de a por b.
            a = b;              // Atualiza a para o valor de b.
            b = resto;         // Atualiza b para o resto calculado.
        }
        return a;  // Retorna o último valor de a, que é o MDC.
    }
}
