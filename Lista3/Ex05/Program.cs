/* 5. O valor de PI pode ser calculado através de várias séries matemáticas. Uma das mais
conhecidas é a série de Leibniz:
PI = 4*(1 - 1/3 + 1/5 - 1/7 + ... + 1/n)
Quanto mais termos, mais próximo do valor de PI. Diante disso, faça um algoritmo deve
receba a quantidade de repetições e escreva e o valor final. */

using System;

class Program
{
    public static void Main()
    {
        // Solicita ao usuário a quantidade de repetições
        Console.WriteLine("Digite a quantidade de repetições:");
        int n = int.Parse(Console.ReadLine());  // Lê o número de repetições e converte para inteiro.
        double pi = 0;  // Inicializa a variável que armazenará o valor de PI.

        // Laço para calcular os termos da série de Leibniz
        for (int i = 0; i <= n; i++)
        {
            // Calcula o termo atual da série, alternando entre positivo e negativo
            double termo = Math.Pow(-1, i) / (2 * i + 1);
            pi += termo;  // Soma o termo ao valor acumulado de PI.

            // Exibe o valor atual de PI e o número da iteração para acompanhamento
            Console.WriteLine(pi + " | " + i);
        }

        // Multiplica o valor acumulado por 4 para obter o valor final aproximado de PI.
        pi *= 4;

        // Exibe o valor final aproximado de PI.
        Console.WriteLine("O valor aproximado de PI é: " + pi);
    }
}
