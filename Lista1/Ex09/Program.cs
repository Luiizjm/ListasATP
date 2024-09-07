/* 9. Fazer um programa que leia a hora, minutos e segundos e exiba a quantidade de segundos
decorridos desde o início do dia. */

using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira a hora
        // Usa int.Parse() para converter a string de entrada em um valor inteiro
        Console.Write("Digite as horas: ");
        int horas = int.Parse(Console.ReadLine());

        // Solicita ao usuário que insira os minutos
        Console.Write("Digite os minutos: ");
        int minutos = int.Parse(Console.ReadLine());

        // Solicita ao usuário que insira os segundos
        Console.Write("Digite os segundos: ");
        int segundos = int.Parse(Console.ReadLine());

        // Converte as horas para segundos (1 hora = 3600 segundos)
        horas = horas * 60 * 60;

        // Converte os minutos para segundos (1 minuto = 60 segundos)
        minutos = minutos * 60;

        // Calcula o total de segundos decorridos desde o início do dia
        // Soma os segundos das horas, minutos e os segundos fornecidos
        int segundos_dia = horas + minutos + segundos;

        // Exibe o total de segundos decorridos desde o início do dia
        Console.Write($"O total de segundos do dia é de: {segundos_dia}.");
    }
}