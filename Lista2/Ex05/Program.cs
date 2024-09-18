/* 5. Crie um programa que simule uma calculadora simples. O usuário deve fornecer dois
números e uma operação (adição, subtração, multiplicação, divisão). O programa deve
executar a operação correspondente e exibir o resultado. */

using System;  // Importa a biblioteca necessária para funções básicas do C#, como leitura de dados do console.

class Program  // Define a classe "Program" que contém o ponto de entrada do programa.
{
    static void Main()  // Método principal que é executado quando o programa inicia.
    {
        double r = 0;  // Declara a variável 'r' para armazenar o resultado das operações.
        
        // Solicita ao usuário que insira o primeiro número.
        Console.Write("Digite um número: ");
        int num1 = int.Parse(Console.ReadLine());  // Lê e converte o número digitado para inteiro.
        
        // Solicita ao usuário que insira o segundo número.
        Console.Write("Digite outro número: ");
        int num2 = int.Parse(Console.ReadLine());  // Lê e converte o número digitado para inteiro.
        
        // Solicita ao usuário que escolha uma operação (adição, subtração, multiplicação ou divisão).
        Console.Write("Escolha seu operador: \n '+' - Soma. \n '-' - Subtração. \n 'x' - Multiplicação. \n '%' - Divisão. \n  = ");
        char op = char.Parse(Console.ReadLine());  // Lê o operador inserido como um caractere.
        Console.WriteLine();

        // Utiliza uma estrutura de controle 'switch' para decidir qual operação realizar com base no operador inserido.
        switch (op)
        {
            // Caso o operador seja '+', realiza a soma dos números.
            case '+':
                r = num1 + num2;  // Calcula a soma.
                Console.WriteLine($"A Soma é: {r}.");  // Exibe o resultado da soma.
                break;

            // Caso o operador seja '-', realiza a subtração dos números.
            case '-':
                r = num1 - num2;  // Calcula a subtração.
                Console.WriteLine($"A Subtração é: {r}.");  // Exibe o resultado da subtração.
                break;

            // Caso o operador seja 'x', realiza a multiplicação dos números.
            case 'x':
                r = num1 * num2;  // Calcula a multiplicação.
                Console.WriteLine($"A Multiplicação é: {r}.");  // Exibe o resultado da multiplicação.
                break;

            // Caso o operador seja '%', realiza a divisão dos números.
            case '%':
                // Verifica se o segundo número é 0, pois a divisão por zero não é permitida.
                if (num2 == 0)
                {
                    // Exibe uma mensagem de erro caso o segundo número seja zero.
                    Console.WriteLine("Não é possível dividir por 0, tente novamente!");
                    break;
                }
                else
                {
                    // Se o segundo número não for zero, realiza a divisão.
                    r = num1 / num2;  // Calcula a divisão.
                    Console.WriteLine($"A divisão é: {r}.");  // Exibe o resultado da divisão.
                    break;
                }
        }
    }
}
