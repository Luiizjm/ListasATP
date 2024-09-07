/* 8. Fazer um programa que leia o valor de um salário a ser pago e informe a quantidade mínima de
notas que precisarão ser sacadas no banco para pagar o funcionário. As notas disponíveis são:
200, 100, 50, 20, 10, 5, 2 reais e 1 real. */

using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o valor do salário a ser pago
        // Usa int.Parse() para converter a string de entrada em um valor inteiro
        Console.Write("Digite o salário a ser pago: ");
        int salario = int.Parse(Console.ReadLine());

        // Calcula a quantidade de notas de R$200 necessárias
        int nota200 = salario / 200;
        // Atualiza o valor do salário restante após retirar as notas de R$200
        salario %= 200;

        // Calcula a quantidade de notas de R$100 necessárias
        int nota100 = salario / 100;
        // Atualiza o valor do salário restante após retirar as notas de R$100
        salario %= 100;

        // Calcula a quantidade de notas de R$50 necessárias
        int nota50 = salario / 50;
        // Atualiza o valor do salário restante após retirar as notas de R$50
        salario %= 50;

        // Calcula a quantidade de notas de R$20 necessárias
        int nota20 = salario / 20;
        // Atualiza o valor do salário restante após retirar as notas de R$20
        salario %= 20;

        // Calcula a quantidade de notas de R$10 necessárias
        int nota10 = salario / 10;
        // Atualiza o valor do salário restante após retirar as notas de R$10
        salario %= 10;

        // Calcula a quantidade de notas de R$5 necessárias
        int nota5 = salario / 5;
        // Atualiza o valor do salário restante após retirar as notas de R$5
        salario %= 5;

        // Calcula a quantidade de notas de R$2 necessárias
        int nota2 = salario / 2;
        // Atualiza o valor do salário restante após retirar as notas de R$2
        salario %= 2;

        // Calcula a quantidade de notas de R$1 necessárias
        int nota1 = salario / 1;
        // Atualiza o valor do salário restante após retirar as notas de R$1
        salario %= 1;

        // Exibe o resultado
        Console.WriteLine("\nNotas de R$200: " + nota200);
        Console.WriteLine("Notas de R$100: " + nota100);
        Console.WriteLine("Notas de R$50: " + nota50);
        Console.WriteLine("Notas de R$20: " + nota20);
        Console.WriteLine("Notas de R$10: " + nota10);
        Console.WriteLine("Notas de R$5: " + nota5);
        Console.WriteLine("Notas de R$2: " + nota2);
        Console.WriteLine("Notas de R$1: " + nota1);
    }
}