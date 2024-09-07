/* 10. Fazer um programa que leia a quantidade de segundos passados desde o início do dia e
transforme em: horas, minutos e segundos. */

using System;

class Program
{
    static void Main()
    {
        // Declara variáveis para armazenar horas, minutos e segundos
        double segundos, minutos, horas;

        // Solicita ao usuário que insira a quantidade de segundos passados desde o início do dia
        // Usa int.Parse() para converter a string de entrada em um valor inteiro
        Console.Write("Digite a quantidade de segundos: ");
        int segundos_dia = int.Parse(Console.ReadLine());

        // Calcula a quantidade de horas
        // 1 hora = 3600 segundos
        // Divide o total de segundos por 3600 para obter o número de horas
        horas = segundos_dia / 3600;

        // Calcula a quantidade de minutos
        // Primeiro calcula os segundos restantes após remover as horas
        // Depois divide esses segundos restantes por 60 para obter o número de minutos
        minutos = (segundos_dia % 3600) / 60;

        // Calcula a quantidade de segundos restantes
        // Usa o operador módulo (%) para obter o restante dos segundos após remover as horas e minutos
        segundos = segundos_dia % 60;

        // Exibe o resultado formatado, mostrando horas, minutos e segundos
        Console.Write($"O Resultado é {horas} Horas, {minutos} Minutos, {segundos} Segundos.");
    }
}