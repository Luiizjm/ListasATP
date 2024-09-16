using System;

class Program
{
    static void Main()
    {
        double r = 0;
        Console.Write("Digite um número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Escolha seu operador: \n '+' - Soma. \n '-' - Subtração. \n 'x' - Multiplicação. \n '%' - Divisão. \n  = ");
        char op = char.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (op)
        {
            case '+':
                r = num1 + num2;
                Console.WriteLine($"A Soma é: {r}.");
                break;

            case '-':
                r = num1 - num2;
                Console.WriteLine($"A Subtação é: {r}.");
                break;

            case 'x':
                r = num1 * num2;
                Console.WriteLine($"A Multiplicação é: {r}.");
                break;

            case '%':

                if (num2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por 0, tente novamente!");
                    break;
                }
                else
                {
                    r = num1 / num2;
                    Console.WriteLine($"A divisão é: {r}.");
                    break;
                }
        }
    }
}