/* 4. Faça um programa que imprima os N primeiros elementos da série de Fibonacci. Por
exemplo, se o usuário digitou o número 20, deverão ser apresentados os 20 números da
sequência na tela. */

using System;

class Program
{
    public static void Main()
    {   
        int a = 0, b = 1, f;

        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++) {
            f = a + b;
            Console.WriteLine(f);
            a = b;
            b = f;
        }
    }
}